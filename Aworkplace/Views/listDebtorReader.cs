using Aworkplace.Models;
using System.Data;

namespace Aworkplace.Views
{
    public partial class listDebtorReader : Form
    {
        List<TypeLiterature> allLiteratures = new List<TypeLiterature>();
        List<TypeReader> allReaders = new List<TypeReader>();
        List<string> incorrectOutput = new List<string>();
        private readonly Functions f = new Functions();

        Dictionary<int, int?> idCard = new Dictionary<int, int?>();
        Dictionary<int, int?> idLiterature = new Dictionary<int, int?>(); 
        Dictionary<Int32, String> typeLiterature = new Dictionary<Int32, String>();

        public listDebtorReader()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.readFromFileForData(ref dataDebtor, ref allReaders, ref allLiteratures, ref typeLiterature, ref incorrectOutput, out idCard, out idLiterature);
        }

      
        private void acceptBookFormButton_Click(object sender, EventArgs e)
        {
            if (dataDebtor.SelectedCells[0].RowIndex != -1)
            {
                string findstring = "";
                string[] allInputLiterature = File.ReadAllLines(LiteratureFromReader.pathFile);


                int? idCardINT = idCard.FirstOrDefault(x => x.Key == dataDebtor.SelectedCells[0].RowIndex).Value;
                int idLiteratureValue = (int)idLiterature.FirstOrDefault(x => x.Key == dataDebtor.SelectedCells[0].RowIndex).Value;

                foreach (var all in allInputLiterature) {
                    string[] line = all.Split(' ');
                    if (Convert.ToInt32(line[0]) == idLiteratureValue && Convert.ToInt32(line[1]) == idCardINT) {
                        findstring = all;
                    }
                }
                allInputLiterature = allInputLiterature.Where(x => x != findstring).ToArray();
                File.WriteAllLines(LiteratureFromReader.pathFile, allInputLiterature);

                foreach (var find in allLiteratures) {
                    if (find.ID == idLiteratureValue) {
                        find.COUNT++;
                        find.UpdateLiterature();
                    } 
                }
                MessageBox.Show("Книга успешно принята!");
                f.readFromFileForData(ref dataDebtor, ref allReaders, ref allLiteratures, ref typeLiterature, ref incorrectOutput, out idCard, out idLiterature);
            }
            else {
                MessageBox.Show("Выделите хотя бы одну строку!!!");
            }
        }
    }
}

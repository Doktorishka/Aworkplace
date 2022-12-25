using Aworkplace.Models;

namespace Aworkplace.Views
{
    public partial class outputLiteratureForReader : Form
    {
        List<TypeLiterature> allLiteratures = new List<TypeLiterature>();
        Dictionary<Int32, String> typeLiterature = new Dictionary<Int32, String>();
        List<TypeReader> allReaders = new List<TypeReader>();
        private readonly Functions f = new Functions();

        public outputLiteratureForReader()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.readFromFileForData(ref dataLiterature, ref dataReaders, ref allLiteratures, ref allReaders, ref typeLiterature);
        }

        private void registerOutputButton_Click(object sender, EventArgs e)
        {
            if (dataReaders.SelectedCells[0].RowIndex != -1 && dataLiterature.SelectedCells[0].RowIndex != -1)
            {
                if (allLiteratures[dataLiterature.SelectedCells[0].RowIndex].COUNT != 0)
                {
                    string outputLiterature = "\n" + allLiteratures[dataLiterature.SelectedCells[0].RowIndex].ID.ToString() + " " + allReaders[dataReaders.SelectedCells[0].RowIndex].IDReaderCard.ToString() + " " + dateOutputLiterature.Value.ToShortDateString();
                    File.AppendAllText(LiteratureFromReader.pathFile, outputLiterature);

                    allLiteratures[dataLiterature.SelectedCells[0].RowIndex].COUNT--;
                    allLiteratures[dataLiterature.SelectedCells[0].RowIndex].UpdateLiterature();
                    f.readFromFileForData(ref dataLiterature, ref dataReaders, ref allLiteratures, ref allReaders, ref typeLiterature);
                }
                else
                {
                    MessageBox.Show("Данного экземпляра нет в наличии");
                }
            }
            else {
                MessageBox.Show("Выберите хоть 1 экземпляр");
            }
        }
    }
}

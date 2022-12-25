using Aworkplace.Models;
using System.Reflection;

namespace Aworkplace.Views
{
    public partial class listReaders : Form
    {
        List<TypeReader> allReaders = new List<TypeReader>();
        Dictionary<Int32, String> typeReader = new Dictionary<Int32, String>();
        Functions f = new Functions();

        public listReaders()
        {
            InitializeComponent();
            dataReaders.ClearSelection();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            string[] allType = File.ReadAllLines(TypeReader.pathFile);
            foreach (string type in allType)
            {
                string[] objectType = type.Split(" ");
                typeReader.Add(Convert.ToInt32(objectType[0]), objectType[1]);
            }

            f.readFromFileForData(ref dataReaders, ref allReaders, ref typeReader);
        }

        private async void addReaderButton_Click(object sender, EventArgs e)
        {
            registerReader rr = new registerReader();
            rr.Show();

            await f.GetTaskFromEvent(rr, "FormClosed");
            f.readFromFileForData(ref dataReaders, ref allReaders, ref typeReader);
        }
        private void rebuildDataGrid_Click(object sender, EventArgs e)
        {
            f.readFromFileForData(ref dataReaders, ref allReaders, ref typeReader);
        }

        private void deleteSelectedItemButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить читателя?", "Внимание",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                if (dataReaders.SelectedCells[0].RowIndex != -1)
                {
                    allReaders[dataReaders.SelectedCells[0].RowIndex].DeleteReader();
                    f.readFromFileForData(ref dataReaders, ref allReaders, ref typeReader);
                }
                else
                {
                    MessageBox.Show("Выделите одну строку в таблице!");
                }
            }          
        }
    }
}

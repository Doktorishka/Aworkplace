using Aworkplace.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aworkplace.Views
{
    public partial class listLiterature : Form
    {
        private List<TypeLiterature> allLiteratures = new List<TypeLiterature>();
        private Dictionary<Int32, String> typeLiterature = new Dictionary<Int32, String>();
        private readonly Functions f = new Functions();

        public listLiterature()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.readFromFileForData(ref dataLiterature, ref allLiteratures, ref typeLiterature);
        }

        private void rebuildDataGrid_Click(object sender, EventArgs e)
        {
            f.readFromFileForData(ref dataLiterature, ref allLiteratures, ref typeLiterature);
        }

        private void deleteSelectedItemButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить читателя?", "Внимание",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataLiterature.SelectedCells[0].RowIndex != -1)
                {
                    allLiteratures[dataLiterature.SelectedCells[0].RowIndex].DeleteLiterature();
                    f.readFromFileForData(ref dataLiterature, ref allLiteratures, ref typeLiterature);
                }
                else
                {
                    MessageBox.Show("Выделите одну строку в таблице!");
                }
            }                
        }

        private async void addLiteratureButton_Click(object sender, EventArgs e)
        {
            registerLiterature rl = new registerLiterature();
            rl.Show();

            await f.GetTaskFromEvent(rl, "FormClosed");
            f.readFromFileForData(ref dataLiterature, ref allLiteratures, ref typeLiterature);
        }
    }
}

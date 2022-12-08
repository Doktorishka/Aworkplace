using Aworkplace.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aworkplace.Views
{
    public partial class listDebtorReader : Form
    {
        List<TypeLiterature> allLiteratures = new List<TypeLiterature>();
        List<TypeReader> allReaders = new List<TypeReader>();
        List<string> incorrectOutput = new List<string>();

        Dictionary<int, int?> idCard = new Dictionary<int, int?>();
        Dictionary<int, int?> idLiterature = new Dictionary<int, int?>();

        


        Dictionary<Int32, String> typeLiterature = new Dictionary<Int32, String>();

        public listDebtorReader()
        {
            InitializeComponent();

            dataDebtor.ColumnCount = 3;

            dataDebtor.Columns[0].HeaderText= "ФИО";
            dataDebtor.Columns[1].HeaderText= "Наименование экземпляра";
            dataDebtor.Columns[2].HeaderText= "Дата возврата";

            string[] allType = File.ReadAllLines("../../../Files/TypeLiterature.txt");
            foreach (string type in allType)
            {
                string[] objectType = type.Split(" ");
                typeLiterature.Add(Convert.ToInt32(objectType[0]), objectType[1]);
            }

            readFromFileForData();
        }

        private void readFromFileForData() {
            allLiteratures.Clear();
            allReaders.Clear();
            incorrectOutput.Clear();
            dataDebtor.Rows.Clear();
            int count = 0;

            string[] allLiterature = File.ReadAllLines("../../../Files/Literature.txt");
            foreach (string literString in allLiterature)
            {
                string[] line = literString.Split(' ');

                TypeLiterature tl = new TypeLiterature();

                tl.ID = int.Parse(line[0]);
                tl.Title = line[1];
                tl.Author = line[2];
                tl.COUNT = Convert.ToInt32(line[3]);
                tl.DateOutput = Convert.ToDateTime(line[4]);
                tl.IdType = Convert.ToInt32(line[5]);
                tl.NameType = typeLiterature.FirstOrDefault(x => x.Key == Convert.ToInt32(line[5])).Value;
                tl.WhoisAutorPrint = line[6];

                allLiteratures.Add(tl);
            }

            string[] allReader = File.ReadAllLines("../../../Files/Readers.txt");
            foreach (string readerString in allReader)
            {
                string[] line = readerString.Split(' ');

                TypeReader tr = new TypeReader();

                tr.ID = Convert.ToInt32(line[0]);
                tr.IDReaderCard = Convert.ToInt32(line[1]);
                tr.LastName = line[2];
                tr.FirstName = line[3];
                tr.Patronomyc = line[4];
                tr.TypeObject = line[7];

                allReaders.Add(tr);
            }

            string[] allOutputLiterature = File.ReadAllLines("../../../Files/OutputLiterature.txt");

            foreach (var all in allOutputLiterature)
            {
                string[] line = all.Split(' ');
                if (Convert.ToDateTime(line[2]) < DateTime.Now)
                {
                    incorrectOutput.Add(all);
                }
            }

            foreach (var incorrect in incorrectOutput) {
                dataDebtor.RowCount++;
                string[] line = incorrect.Split(" ");
                foreach (var l in allLiteratures) {
                    if (Convert.ToInt32(line[0]) == l.ID) {
                        dataDebtor.Rows[dataDebtor.RowCount - 1].Cells[1].Value = l.Title;
                        idLiterature.Add(dataDebtor.RowCount - 1, l.ID);
                    }
                }
                foreach (var r in allReaders) {
                    if (Convert.ToInt32(line[1]) == r.IDReaderCard) {
                        string fio = r.LastName + " " + r.FirstName + " " + r.Patronomyc;
                        dataDebtor.Rows[dataDebtor.RowCount - 1].Cells[0].Value = fio;
                        idCard.Add(dataDebtor.RowCount - 1, r.IDReaderCard);
                    }
                }
                dataDebtor.Rows[dataDebtor.RowCount - 1].Cells[2].Value = line[2];
            }
        }

        private void acceptBookFormButton_Click(object sender, EventArgs e)
        {
            if (dataDebtor.SelectedCells[0].RowIndex != -1)
            {

            }
            else {
                MessageBox.Show("Выделите хотя бы одну строку!!!");
            }
        }
    }
}

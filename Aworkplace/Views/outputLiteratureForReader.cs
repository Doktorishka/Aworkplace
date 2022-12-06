using Aworkplace.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aworkplace.Views
{
    public partial class outputLiteratureForReader : Form
    {
        List<TypeLiterature> allLiteratures = new List<TypeLiterature>();
        Dictionary<Int32, String> typeLiterature = new Dictionary<Int32, String>();
        List<TypeReader> allReaders = new List<TypeReader>();

        public outputLiteratureForReader()
        {
            InitializeComponent();

            dataLiterature.ColumnCount = 4;
            dataLiterature.Columns[0].HeaderText = "Наименование экземпляра";
            dataLiterature.Columns[1].HeaderText = "Автор";
            dataLiterature.Columns[2].HeaderText = "В наличии";
            dataLiterature.Columns[3].HeaderText = "Тип экземпляра";

            dataReaders.ColumnCount = 1;
            dataReaders.Columns[0].HeaderText = "ФИО";


            string[] allType = File.ReadAllLines("../../../Files/TypeLiterature.txt");
            foreach (string type in allType)
            {
                string[] objectType = type.Split(" ");
                typeLiterature.Add(Convert.ToInt32(objectType[0]), objectType[1]);
            }
            readFromFileForData();
        }

        private void readFromFileForData() {
            string[] allLiterature = File.ReadAllLines("../../../Files/Literature.txt");
            foreach (string literString in allLiterature)
            {
                string[] line = literString.Split(' ');

                TypeLiterature tl = new TypeLiterature();

                tl.ID = int.Parse(line[0]);
                tl.Title = line[1];
                tl.Author = line[2];
                tl.COUNT = Convert.ToInt32(line[3]);
                tl.NameType = typeLiterature.FirstOrDefault(x => x.Key == Convert.ToInt32(line[5])).Value;

                allLiteratures.Add(tl);
            }

            dataLiterature.RowCount = allLiteratures.Count;

            for (int i = 0; i < dataLiterature.RowCount; i++)
            {
                dataLiterature.Rows[i].Cells[0].Value = allLiteratures[i].Title;
                dataLiterature.Rows[i].Cells[1].Value = allLiteratures[i].Author;
                dataLiterature.Rows[i].Cells[2].Value = allLiteratures[i].COUNT;
                dataLiterature.Rows[i].Cells[3].Value = allLiteratures[i].NameType;
                dataLiterature.Rows[i].HeaderCell.Value = allLiteratures[i].ID.ToString();
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

            dataReaders.RowCount = allReaders.Count;

            for (int i = 0; i < dataReaders.RowCount; i++)
            {
                string fio = allReaders[i].LastName + " " + allReaders[i].FirstName + " " + allReaders[i].Patronomyc;


                dataReaders.Rows[i].Cells[0].Value = fio;
                dataReaders.Rows[i].HeaderCell.Value = allReaders[i].IDReaderCard.ToString();
            }
        }

        private void registerOutputButton_Click(object sender, EventArgs e)
        {
            if (dataReaders.SelectedCells[0].RowIndex != -1 && dataLiterature.SelectedCells[0].RowIndex != -1)
            {
                string outputLiterature = "\n" + allLiteratures[dataLiterature.SelectedCells[0].RowIndex].ID.ToString() + " " + allReaders[dataReaders.SelectedCells[0].RowIndex].IDReaderCard.ToString() + " " + dateOutputLiterature.Value.ToShortDateString();
                File.AppendAllText("../../../Files/OutputLiterature.txt", outputLiterature);
            }
        }
    }
}

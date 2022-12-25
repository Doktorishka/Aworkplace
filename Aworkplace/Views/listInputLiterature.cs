using Aworkplace.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Aworkplace.Views
{
    public partial class listInputLiterature : Form
    {
        readonly Functions f = new Functions();
        readonly List<TypeLiterature> allLiteratures = new List<TypeLiterature>();
        readonly Dictionary<Int32, String> typeLiterature = new Dictionary<Int32, String>();
        readonly List<TypeReader> allReaders = new List<TypeReader>();
        readonly List<string> incorrectOutput = new List<string>();

        public listInputLiterature()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataLiterature.ColumnCount = 5;
            dataLiterature.Columns[0].HeaderText = "ИД";
            dataLiterature.Columns[1].HeaderText = "Наименование экземпляра";
            dataLiterature.Columns[2].HeaderText = "Автор";
            dataLiterature.Columns[3].HeaderText = "Кол-во в пользовании";
            dataLiterature.Columns[4].HeaderText = "У кого";

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
            dataLiterature.Rows.Clear();

            string[] allLiterature = File.ReadAllLines("../../../Files/Literature.txt");
            foreach (string literString in allLiterature)
            {
                string[] line = literString.Split(' ');

                TypeLiterature tl = new TypeLiterature
                {
                    ID = Convert.ToInt32(line[0]),
                    Title = line[1],
                    Author = line[2],
                    COUNT = Convert.ToInt32(line[3]),
                    DateOutput = Convert.ToDateTime(line[4]),
                    IdType = Convert.ToInt32(line[5]),
                    NameType = typeLiterature.FirstOrDefault(x => x.Key == Convert.ToInt32(line[5])).Value,
                    WhoisAutorPrint = line[6]
                };
                allLiteratures.Add(tl);
            }

            string[] allReader = File.ReadAllLines("../../../Files/Readers.txt");
            foreach (string readerString in allReader)
            {
                string[] line = readerString.Split(' ');

                TypeReader tr = new TypeReader
                {
                    ID = Convert.ToInt32(line[0]),
                    IDReaderCard = Convert.ToInt32(line[1]),
                    LastName = line[2],
                    FirstName = line[3],
                    Patronomyc = line[4],
                    TypeObject = line[7]
                };

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
                
                string[] line = incorrect.Split(' ');
                foreach(var l in allLiteratures)
                {
                    foreach (var r in allReaders)
                    if (Convert.ToInt32(line[0]) == l.ID && Convert.ToInt32(line[1]) == r.IDReaderCard) {
                            dataLiterature.RowCount++;
                            string fio = r.LastName + " " + r.FirstName + " " + r.Patronomyc;
                        dataLiterature.Rows[dataLiterature.RowCount - 1].Cells[0].Value = l.ID;
                        dataLiterature.Rows[dataLiterature.RowCount - 1].Cells[1].Value = l.Title;
                        dataLiterature.Rows[dataLiterature.RowCount - 1].Cells[2].Value = l.Author;
                        dataLiterature.Rows[dataLiterature.RowCount - 1].Cells[3].Value = l.COUNT;
                        dataLiterature.Rows[dataLiterature.RowCount - 1].Cells[4].Value = fio;
                        
                        }  
                }
            }
        }

        private async void issuesBookFormButton_Click(object sender, EventArgs e)
        {
            outputLiteratureForReader o = new outputLiteratureForReader();
            o.Show();

            await f.GetTaskFromEvent(o, "FormClosed");
            readFromFileForData();
        }
    }
}

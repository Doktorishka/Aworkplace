using Aworkplace.Models.Interfaces;

namespace Aworkplace.Models
{
    public class Functions : IFunctions
    {
        public bool isValidation(params string[] strings)
        {
            bool rule = true;

            foreach (string line in strings) { 
                if(line == null || line == String.Empty || line == "") rule = false;
            }
            return rule;
        }

        public bool isValidation(decimal number, params string[] strings)
        {
            bool rule = true;

            foreach (string line in strings)
            {
                if (line == null || line == String.Empty || line == "") rule = false;
            }
            if (number == -1 || number == null) rule = false;
                
            return rule;
        }


        public void readFromFileForData(in string path, ref DataGridView data, ref List<TypeReader> reader, ref Dictionary<int, string> typeReader)
        {
            data.Rows.Clear();
            data.Columns.Clear();
            reader.Clear();

            data.ColumnCount = 6;
            data.Columns[0].HeaderText = "Фамилия";
            data.Columns[1].HeaderText = "Имя";
            data.Columns[2].HeaderText = "Отчество";
            data.Columns[3].HeaderText = "Дата рождения";
            data.Columns[4].HeaderText = "Тип читателя";
            data.Columns[5].HeaderText = "Место";

            string[] allReaders = File.ReadAllLines(path);

            foreach (string readerString in allReaders) {
                string[] line = readerString.Split(' ');

                        TypeReader tr = new TypeReader();

                        tr.ID = Convert.ToInt32(line[0]);
                        tr.IDReaderCard = Convert.ToInt32(line[1]);
                        tr.LastName = line[2];
                        tr.FirstName = line[3];
                        tr.Patronomyc = line[4];
                        tr.DateBirth = Convert.ToDateTime(line[5]);
                        tr.Identificator = Convert.ToInt32(line[6]);
                        tr.TypeObject = line[7];
                        tr.NameType = typeReader.FirstOrDefault(x => x.Key == Convert.ToInt32(line[6])).Value;

                        reader.Add(tr);
            }

            data.RowCount = reader.Count;

            for (int i = 0; i < data.RowCount; i++) {
                data.Rows[i].Cells[0].Value = reader[i].LastName;
                data.Rows[i].Cells[1].Value = reader[i].FirstName;
                data.Rows[i].Cells[2].Value = reader[i].Patronomyc;
                data.Rows[i].Cells[3].Value = reader[i].DateBirth.Value.ToShortDateString();
                data.Rows[i].Cells[4].Value = reader[i].NameType;
                data.Rows[i].Cells[5].Value = reader[i].TypeObject;
                data.Rows[i].HeaderCell.Value = reader[i].IDReaderCard.ToString();
            }

        }

        public void readFromFileForData(out DataGridView data, out TypeLiterature literature, out Dictionary<int, string> typeLiterature)
        {
            throw new NotImplementedException();
        }

        public void readFromFileForData(out DataGridView dataLiterature, out DataGridView dataReader, out TypeLiterature literature, out Dictionary<int, string> typeLiterature)
        {
            throw new NotImplementedException();
        }

        
    }
}

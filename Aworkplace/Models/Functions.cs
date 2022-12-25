using Aworkplace.Models.Interfaces;
using System.Reflection;
using System.Security.AccessControl;


namespace Aworkplace.Models
{
    public class Functions : IFunctions
    {
        public List<TypeLiterature> getLiteratures()
        {
            List<TypeLiterature> list = new List<TypeLiterature>();
            Dictionary<int, string> typeLiterature = getType(TypeLiterature.pathFile);


            string[] allLiterature = File.ReadAllLines(Literature.pathFile);
            foreach (string literString in allLiterature)
            {
                string[] line = literString.Split(' ');

                TypeLiterature tl = new TypeLiterature
                {
                    ID = int.Parse(line[0]),
                    Title = line[1],
                    Author = line[2],
                    COUNT = Convert.ToInt32(line[3]),
                    DateOutput = Convert.ToDateTime(line[4]),
                    IdType = Convert.ToInt32(line[5]),
                    //Следующая строка - 
                    /*
                     * FirstOrDefault - метод выполняющий поиск по заданому условию, возвращающий пару ключ-значение при true
                     * Лямбда-выражение x => x.Key == Convert.ToInt32(line[5]) - условие поиска возращающий пару к-з и условие при котором должен эту пару вернуть
                     * FirstOrDefault(Лямбда-выражение).Value - из пары к-з вытаскиваем знчение
                     */
                    NameType = typeLiterature.FirstOrDefault(x => x.Key == Convert.ToInt32(line[5])).Value,
                    WhoisAutorPrint = line[6]
                };
                list.Add(tl);
            }

            return list;
        }

        public Dictionary<int, string> getType(string path)
        {
            // int == Int32 != Int16 != Int64
            // int: хранит целое число от -2 147 483 648 до 2 147 483 647 - 4 byte
            // uint: хранит целое число от 0 до 4 294 967 295 - 4 byte
            // short: хранит целое число от -32768 до 32767
            // ushort: хранит целое число от 0 до 65535 
            Dictionary<int, String> type = new Dictionary<int, string>();
            string[] allType = File.ReadAllLines(path);
            foreach (string t in allType)
            {
                string[] objectType = t.Split(" ");
                type.Add(Convert.ToInt32(objectType[0]), objectType[1]);
            }
            return type;
        }

        public List<TypeReader> getReaders()
        {
            List<TypeReader> list = new List<TypeReader>();

            Dictionary<int, string> typeReader = getType(TypeReader.pathFile);

            string[] allReaders = File.ReadAllLines(Reader.pathFile);

            foreach (string readerString in allReaders)
            {
                string[] line = readerString.Split(' ');

                TypeReader tr = new TypeReader()
                {
                    ID = Convert.ToInt32(line[0]),
                    IDReaderCard = Convert.ToInt32(line[1]),
                    LastName = line[2],
                    FirstName = line[3],
                    Patronomyc = line[4],
                    DateBirth = Convert.ToDateTime(line[5]),
                    Identificator = Convert.ToInt32(line[6]),
                    TypeObject = line[7],
                    NameType = typeReader.FirstOrDefault(x => x.Key == Convert.ToInt32(line[6])).Value
                };

                list.Add(tr);
            }

            return list;
        }

        public Task<object> GetTaskFromEvent(object o, string evt)
        {
            if (o == null || evt == null) throw new ArgumentNullException("Нулевой аргумент");

            EventInfo einfo = o.GetType().GetEvent(evt);
            if (einfo == null)
            {
                throw new ArgumentException(String.Format("У объекта *{0}* нет событий *{1}* ", o, evt));
            }

            TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
            MethodInfo mi = null;
            Delegate deleg = null;
            EventHandler handler = null;

            //код обработчика события
            handler = (s, e) =>
            {
                mi = handler.Method;
                deleg = Delegate.CreateDelegate(einfo.EventHandlerType, handler.Target, mi);
                einfo.RemoveEventHandler(s, deleg); //отцепляем обработчик события
                tcs.TrySetResult(null); //сигнализируем о наступлении события
            };

            mi = handler.Method;
            deleg = Delegate.CreateDelegate(einfo.EventHandlerType, handler.Target, mi); //получаем делегат нужного типа
            einfo.AddEventHandler(o, deleg); //присоединяем обработчик события
            return tcs.Task;
        }

        #region Валидация

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

        #endregion

        public void readFromFileForData(ref DataGridView data, ref List<TypeReader> reader, ref Dictionary<int, string> typeReader)
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

            reader = getReaders();
               
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

        public void readFromFileForData(ref DataGridView data, ref List<TypeLiterature> literature, ref Dictionary<int, string> typeLiterature)
        {
            data.Rows.Clear();
            literature.Clear();
            typeLiterature.Clear();

            data.ColumnCount = 6;
            data.Columns[0].HeaderText = "Наименование экземпляра";
            data.Columns[1].HeaderText = "Наименование автора";
            data.Columns[2].HeaderText = "Количество экземпляров";
            data.Columns[3].HeaderText = "Дата публикации";
            data.Columns[4].HeaderText = "Тип литературы";
            data.Columns[5].HeaderText = "Издательство";

            typeLiterature = getType(TypeLiterature.pathFile);

            literature = getLiteratures();

            data.RowCount = literature.Count;

            for (int i = 0; i < data.RowCount; i++)
            {
                data.Rows[i].Cells[0].Value = literature[i].Title;
                data.Rows[i].Cells[1].Value = literature[i].Author;
                data.Rows[i].Cells[2].Value = literature[i].COUNT;
                data.Rows[i].Cells[3].Value = literature[i].DateOutput.Value.ToShortDateString();
                data.Rows[i].Cells[4].Value = literature[i].NameType;
                data.Rows[i].Cells[5].Value = literature[i].WhoisAutorPrint;
                data.Rows[i].HeaderCell.Value = literature[i].ID.ToString();
            }

        }

        public void readFromFileForData(ref DataGridView dataLiterature, ref DataGridView dataReader, ref List<TypeLiterature> literatures, ref List<TypeReader> readers, ref Dictionary<int, string> typeLiterature)
        {
            literatures.Clear();
            readers.Clear();
            dataReader.Rows.Clear();
            dataLiterature.Rows.Clear();
            typeLiterature.Clear();

            typeLiterature = getType(TypeLiterature.pathFile);

            dataLiterature.ColumnCount = 4;
            dataLiterature.Columns[0].HeaderText = "Наименование экземпляра";
            dataLiterature.Columns[1].HeaderText = "Автор";
            dataLiterature.Columns[2].HeaderText = "В наличии";
            dataLiterature.Columns[3].HeaderText = "Тип экземпляра";

            dataReader.ColumnCount = 1;
            dataReader.Columns[0].HeaderText = "ФИО";

            literatures = getLiteratures();

            dataLiterature.RowCount = literatures.Count;

            for (int i = 0; i < dataLiterature.RowCount; i++)
            {
                dataLiterature.Rows[i].Cells[0].Value = literatures[i].Title;
                dataLiterature.Rows[i].Cells[1].Value = literatures[i].Author;
                dataLiterature.Rows[i].Cells[2].Value = literatures[i].COUNT;
                dataLiterature.Rows[i].Cells[3].Value = literatures[i].NameType;
                dataLiterature.Rows[i].HeaderCell.Value = literatures[i].ID.ToString();
            }

            readers = getReaders();

            dataReader.RowCount = readers.Count;

            for (int i = 0; i < dataReader.RowCount; i++)
            {
                string fio = readers[i].LastName + " " + readers[i].FirstName + " " + readers[i].Patronomyc;
                dataReader.Rows[i].Cells[0].Value = fio;
                dataReader.Rows[i].HeaderCell.Value = readers[i].IDReaderCard.ToString();
            }
        }

        public void readFromFileForData(ref DataGridView data, ref List<TypeReader> reader, ref List<TypeLiterature> literature, ref Dictionary<int, string> typeLiterature, ref List<string> Output, out Dictionary<int, int?> idCard, out Dictionary<int, int?> idLiterature)
        {
            literature.Clear();
            reader.Clear();
            Output.Clear();
            data.Rows.Clear();
            idLiterature = new Dictionary<int, int?>();
            idCard = new Dictionary<int, int?>();


            data.ColumnCount = 3;

            data.Columns[0].HeaderText = "ФИО";
            data.Columns[1].HeaderText = "Наименование экземпляра";
            data.Columns[2].HeaderText = "Дата возврата";

            typeLiterature = getType(TypeLiterature.pathFile);
            reader = getReaders();
            literature = getLiteratures();

            string[] allOutputLiterature = File.ReadAllLines(LiteratureFromReader.pathFile);

            foreach (var all in allOutputLiterature)
            {
                string[] line = all.Split(' ');
                if (Convert.ToDateTime(line[2]) < DateTime.Now)
                {
                    Output.Add(all);
                }
            }

            foreach (var incorrect in Output)
            {
                data.RowCount++;
                string[] line = incorrect.Split(" ");
                foreach (var l in literature)
                {
                    if (Convert.ToInt32(line[0]) == l.ID)
                    {
                        data.Rows[data.RowCount - 1].Cells[1].Value = l.Title;
                        idLiterature.Add(data.RowCount - 1, l.ID);
                    }
                }
                foreach (var r in reader)
                {
                    if (Convert.ToInt32(line[1]) == r.IDReaderCard)
                    {
                        string fio = r.LastName + " " + r.FirstName + " " + r.Patronomyc;
                        data.Rows[data.RowCount - 1].Cells[0].Value = fio;
                        idCard.Add(data.RowCount - 1, r.IDReaderCard);
                    }
                }
                data.Rows[data.RowCount - 1].Cells[2].Value = line[2];
            }

        }
    }
}

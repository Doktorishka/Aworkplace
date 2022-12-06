using Aworkplace.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aworkplace.Views
{
    public partial class listReaders : Form
    {
        List<TypeReader> allReaders = new List<TypeReader>();
        Dictionary<Int32, String> typeReader = new Dictionary<Int32, String>();
        
        public listReaders()
        {
            InitializeComponent();

            dataReaders.ColumnCount = 6;
            dataReaders.Columns[0].HeaderText = "Фамилия";
            dataReaders.Columns[1].HeaderText = "Имя";
            dataReaders.Columns[2].HeaderText = "Отчество";
            dataReaders.Columns[3].HeaderText = "Дата рождения";
            dataReaders.Columns[4].HeaderText = "Тип читателя";
            dataReaders.Columns[5].HeaderText = "Место";

            string[] allType = File.ReadAllLines("../../../Files/TypeReader.txt");
            foreach (string type in allType)
            {
                string[] objectType = type.Split(" ");
                typeReader.Add(Convert.ToInt32(objectType[0]), objectType[1]);
            }

            readFromFileForData();
        }

        public static Task<object> GetTaskFromEvent(object o, string evt)
        {
            if (o == null || evt == null) throw new ArgumentNullException("Arguments cannot be null");

            EventInfo einfo = o.GetType().GetEvent(evt);
            if (einfo == null)
            {
                throw new ArgumentException(String.Format("*{0}* has no *{1}* event", o, evt));
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

        private void readFromFileForData() {

            dataReaders.Rows.Clear();
            allReaders.Clear();

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
                tr.DateBirth = Convert.ToDateTime(line[5]);
                tr.Identificator = Convert.ToInt32(line[6]);
                tr.TypeObject = line[7];
                tr.NameType = typeReader.FirstOrDefault(x => x.Key == Convert.ToInt32(line[6])).Value;

                allReaders.Add(tr);
            }

            dataReaders.RowCount = allReaders.Count;

            for (int i = 0; i < dataReaders.RowCount; i++) {
                dataReaders.Rows[i].Cells[0].Value = allReaders[i].LastName;
                dataReaders.Rows[i].Cells[1].Value = allReaders[i].FirstName;
                dataReaders.Rows[i].Cells[2].Value = allReaders[i].Patronomyc;
                dataReaders.Rows[i].Cells[3].Value = allReaders[i].DateBirth.Value.ToShortDateString();
                dataReaders.Rows[i].Cells[4].Value = allReaders[i].NameType;
                dataReaders.Rows[i].Cells[5].Value = allReaders[i].TypeObject;
                dataReaders.Rows[i].HeaderCell.Value = allReaders[i].IDReaderCard.ToString();
            }

        }

        private async void addReaderButton_Click(object sender, EventArgs e)
        {
            registerReader rr = new registerReader();
            rr.Show();

            await GetTaskFromEvent(rr, "FormClosed");
            readFromFileForData();
        }
        private void rebuildDataGrid_Click(object sender, EventArgs e)
        {
            readFromFileForData();
        }

        private void deleteSelectedItemButton_Click(object sender, EventArgs e)
        {
            if (dataReaders.SelectedCells[0].RowIndex != -1)
            {
                allReaders[dataReaders.SelectedCells[0].RowIndex].DeleteReader();
                readFromFileForData();
            }
            else {
                MessageBox.Show("Выделите одну строку в таблице!");
            }
        }
    }
}

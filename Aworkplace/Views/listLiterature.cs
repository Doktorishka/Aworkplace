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
        List<TypeLiterature> allLiteratures = new List<TypeLiterature>();
        Dictionary<Int32, String> typeLiterature = new Dictionary<Int32, String>();

        public listLiterature()
        {
            InitializeComponent();

            dataLiterature.ColumnCount = 6;
            dataLiterature.Columns[0].HeaderText = "Наименование экземпляра";
            dataLiterature.Columns[1].HeaderText = "Наименование автора";
            dataLiterature.Columns[2].HeaderText = "Количество экземпляров";
            dataLiterature.Columns[3].HeaderText = "Дата публикации";
            dataLiterature.Columns[4].HeaderText = "Тип литературы";
            dataLiterature.Columns[5].HeaderText = "Издательство";

            string[] allType = File.ReadAllLines("../../../Files/TypeLiterature.txt");
            foreach (string type in allType)
            {
                string[] objectType = type.Split(" ");
                typeLiterature.Add(Convert.ToInt32(objectType[0]), objectType[1]);
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

        private void readFromFileForData(){
            dataLiterature.Rows.Clear();
            allLiteratures.Clear();

            string[] allLiterature = File.ReadAllLines("../../../Files/Literature.txt");
            foreach (string literString in allLiterature)
            {
                string[] line = literString.Split(' ');

                TypeLiterature tl = new TypeLiterature();

                tl.ID= int.Parse(line[0]);
                tl.Title = line[1];
                tl.Author = line[2];
                tl.COUNT= Convert.ToInt32(line[3]);
                tl.DateOutput= Convert.ToDateTime(line[4]);
                tl.IdType = Convert.ToInt32(line[5]);
                tl.NameType = typeLiterature.FirstOrDefault(x => x.Key == Convert.ToInt32(line[5])).Value;
                tl.WhoisAutorPrint = line[6];

                allLiteratures.Add(tl);
            }

            dataLiterature.RowCount = allLiteratures.Count;

            for (int i = 0; i < dataLiterature.RowCount; i++)
            {
                dataLiterature.Rows[i].Cells[0].Value = allLiteratures[i].Title;
                dataLiterature.Rows[i].Cells[1].Value = allLiteratures[i].Author;
                dataLiterature.Rows[i].Cells[2].Value = allLiteratures[i].COUNT;
                dataLiterature.Rows[i].Cells[3].Value = allLiteratures[i].DateOutput.Value.ToShortDateString();
                dataLiterature.Rows[i].Cells[4].Value = allLiteratures[i].NameType;
                dataLiterature.Rows[i].Cells[5].Value = allLiteratures[i].WhoisAutorPrint;
                dataLiterature.Rows[i].HeaderCell.Value = allLiteratures[i].ID.ToString();
            }
        }

        private void rebuildDataGrid_Click(object sender, EventArgs e)
        {
            readFromFileForData();
        }

        private void deleteSelectedItemButton_Click(object sender, EventArgs e)
        {
            if (dataLiterature.SelectedCells[0].RowIndex != -1)
            {
                allLiteratures[dataLiterature.SelectedCells[0].RowIndex].DeleteLiterature();
                readFromFileForData();
            }
            else
            {
                MessageBox.Show("Выделите одну строку в таблице!");
            }
        }

        private async void addLiteratureButton_Click(object sender, EventArgs e)
        {
            registerLiterature rl = new registerLiterature();
            rl.Show();

            await GetTaskFromEvent(rl, "FormClosed");
            readFromFileForData();
        }
    }
}

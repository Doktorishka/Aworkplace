using Aworkplace.Models;
using Aworkplace.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aworkplace.Views
{
    public partial class listInputLiterature : Form
    {
        List<TypeLiterature> allLiteratures = new List<TypeLiterature>();
        Dictionary<Int32, String> typeLiterature = new Dictionary<Int32, String>();
        List<TypeReader> allReaders = new List<TypeReader>();

        public listInputLiterature()
        {
            InitializeComponent();

            dataLiterature.ColumnCount = 4;
            dataLiterature.Columns[0].HeaderText = "Наименование экземпляра";
            dataLiterature.Columns[1].HeaderText = "Автор";
            dataLiterature.Columns[2].HeaderText = "В наличии";
            dataLiterature.Columns[3].HeaderText = "Тип экземпляра";

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

                TypeLiterature tl = new TypeLiterature();

                tl.ID = int.Parse(line[0]);
                tl.Title = line[1];
                tl.Author = line[2];
                tl.COUNT = Convert.ToInt32(line[3]);
                tl.DateOutput = Convert.ToDateTime(line[4]);
                tl.ID = Convert.ToInt32(line[5]);
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
                dataLiterature.Rows[i].Cells[3].Value = allLiteratures[i].NameType;
                dataLiterature.Rows[i].HeaderCell.Value = allLiteratures[i].ID.ToString();
            }

            //foreach (var incorrect in incorrectOutput)
            //{
            //    dataDebtor.RowCount++;
            //    string[] line = incorrect.Split(" ");
            //    foreach (var l in allLiteratures)
            //    {
            //        if (Convert.ToInt32(line[0]) == l.ID)
            //        {
            //            dataDebtor.Rows[dataDebtor.RowCount - 1].Cells[1].Value = l.Title;
            //            idLiterature.Add(dataDebtor.RowCount - 1, l.ID);
            //        }
            //    }
            //    foreach (var r in allReaders)
            //    {
            //        if (Convert.ToInt32(line[1]) == r.IDReaderCard)
            //        {
            //            string fio = r.LastName + " " + r.FirstName + " " + r.Patronomyc;
            //            dataDebtor.Rows[dataDebtor.RowCount - 1].Cells[0].Value = fio;
            //            idCard.Add(dataDebtor.RowCount - 1, r.IDReaderCard);
            //        }
            //    }
            //    dataDebtor.Rows[dataDebtor.RowCount - 1].Cells[2].Value = line[2];
            //}
        }

        public static Task<object> GetTaskFromEvent(object o, string evt)
        {
            if (o == null || evt == null) throw new ArgumentNullException("Аргумент имеет значения null");

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

        private async void issuesBookFormButton_Click(object sender, EventArgs e)
        {
            outputLiteratureForReader o = new outputLiteratureForReader();
            o.Show();

            await GetTaskFromEvent(o, "FormClosed");
            readFromFileForData();
        }
    }
}

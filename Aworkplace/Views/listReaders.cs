using Aworkplace.Models;
using System.Reflection;

namespace Aworkplace.Views
{
    public partial class listReaders : Form
    {
        List<TypeReader> allReaders = new List<TypeReader>();
        Dictionary<Int32, String> typeReader = new Dictionary<Int32, String>();
        string path = "../../../Files/Readers.txt";

        /*
            Сноска
            

            джирик/дженерик
            Dictionary<TKey, TValue> [имя_переменной] = [инициализация]; -- словарь(словарь ресурсов(WPF));

            Dictionary<int, string> dict = new Dictionary<int, string>();
            
            dict.Add(1, "Привет);
            dict.Add(2, "Мир");

            1 Привет
            2 Мир
         
         */

        Functions f = new Functions();

        public listReaders()
        {
            InitializeComponent();

            string[] allType = File.ReadAllLines("../../../Files/TypeReader.txt");
            foreach (string type in allType)
            {
                string[] objectType = type.Split(" ");
                typeReader.Add(Convert.ToInt32(objectType[0]), objectType[1]);
            }

            f.readFromFileForData(path, ref dataReaders, ref allReaders, ref typeReader);
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

        private async void addReaderButton_Click(object sender, EventArgs e)
        {
            registerReader rr = new registerReader();
            rr.Show();

            await GetTaskFromEvent(rr, "FormClosed");
            f.readFromFileForData(path, ref dataReaders, ref allReaders, ref typeReader);
        }
        private void rebuildDataGrid_Click(object sender, EventArgs e)
        {
            f.readFromFileForData(path, ref dataReaders, ref allReaders, ref typeReader);
        }

        private void deleteSelectedItemButton_Click(object sender, EventArgs e)
        {
            if (dataReaders.SelectedCells[0].RowIndex != -1)
            {
                allReaders[dataReaders.SelectedCells[0].RowIndex].DeleteReader();
                f.readFromFileForData(path, ref dataReaders, ref allReaders, ref typeReader);
            }
            else {
                MessageBox.Show("Выделите одну строку в таблице!");
            }
        }
    }
}

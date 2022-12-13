using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aworkplace.Models.Interfaces
{
    public interface IFunctions
    {
        /// <summary> 
        /// Чтение читателя из файла и запись данных в DataGridView формы пользователя
        /// </summary>
        /// <param name="data">DataGridView формы пользователя</param>
        /// <param name="reader"> Список читателей</param>
        /// <param name="typeReader">Словарь типов читателей</param>

        void readFromFileForData(ref DataGridView data, ref List<TypeReader> reader, ref Dictionary<Int32, String> typeReader);


        void readFromFileForData(ref DataGridView data, ref List<TypeReader> reader, ref List<TypeLiterature> literature, ref Dictionary<int, string> typeLiterature, ref List<string> Output, out Dictionary<int, int?> idCard, out Dictionary<int, int?> idLiterature);


        /// <summary>
        /// Чтение литературы из файла и запись данных в DataGridView формы пользователя
        /// </summary>
        /// <param name="data"></param>
        /// <param name="literature"></param>
        /// <param name="typeLiterature"></param>
        void readFromFileForData(ref DataGridView data, ref List<TypeLiterature> literature, ref Dictionary<Int32, String> typeLiterature);


        /// <summary>
        /// Чтение литературы и читателей и запись данных в DataGridViews формы пользователя, используется для формы Список должников
        /// </summary>
        /// <param name="dataLiterature">DataGridView Литературы</param>
        /// <param name="dataReader">DataGridView Читателей</param>
        /// <param name="literatures">Список литературы</param>
        /// <param name="readers">Список читателей в должниках</param>
        /// <param name="typeLiterature">Словарь типов литературы</param>
        void readFromFileForData(ref DataGridView dataLiterature,ref DataGridView dataReader, ref List<TypeLiterature> literatures,ref List<TypeReader> readers, ref Dictionary<Int32, String> typeLiterature);

        /// <summary>
        /// Проверка введенных полей пользователем
        /// </summary>
        /// <param name="strings">Массив валидаций</param>
        /// <returns></returns>
        bool isValidation(params string[] strings);

        /// <summary>
        /// Проверка введенных полей пользователем с учетом типов данных
        /// </summary>
        /// <param name="number"> Число </param>
        /// <param name="strings">Массив валидаций</param>
        /// <returns></returns>
        bool isValidation(decimal number, params string[] strings); 

        /// <summary>
        /// Метод ожидания выполнения задач объекта в потоке
        /// </summary>
        /// <param name="o">Объект который отслеживаем</param>
        /// <param name="evt">Событие у объекта которое должно произойти</param>
        /// <returns></returns>
        Task<object> GetTaskFromEvent(object o, string evt);

        List<TypeLiterature> getLiteratures();

        List<TypeReader> getReaders();

        Dictionary<Int32, String> getType(string path);

    }
}

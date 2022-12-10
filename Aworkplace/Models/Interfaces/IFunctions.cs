using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aworkplace.Models.Interfaces
{
    public interface IFunctions
    {
        // out in readonly

        /// <summary> 
        /// Чтение читателя из файла и запись данных в DataGridView формы пользователя
        /// </summary>
        /// <param name="data">DataGridView формы пользователя, используется как выходной параметр</param>
        /// <param name="reader"> Список читателей, используется как выходной параметр </param>
        /// <param name="typeReader">Словарь типов читателей, используется как выходной параметр</param>
        void readFromFileForData(in string path, ref DataGridView data, ref List<TypeReader> reader, ref Dictionary<Int32, String> typeReader);


        /// <summary>
        /// Чтение литературы из файла и запись данных в DataGridView формы пользователя
        /// </summary>
        /// <param name="data"></param>
        /// <param name="literature"></param>
        /// <param name="typeLiterature"></param>
        void readFromFileForData(out DataGridView data, out TypeLiterature literature, out Dictionary<Int32, String> typeLiterature);

        /// <summary>
        /// Чтение литературы и читателей и запись данных в DataGridViews формы пользователя
        /// </summary>
        /// <param name="dataLiterature">DataGridView Литературы</param>
        /// <param name="dataReader">DataGridView Читателей</param>
        /// <param name="literature">Список литературы</param>
        /// <param name="typeLiterature">Словарь типов литературы</param>
        void readFromFileForData(out DataGridView dataLiterature,out DataGridView dataReader, out TypeLiterature literature, out Dictionary<Int32, String> typeLiterature);

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

        //static Task<object> GetTaskFromEvent(object o, string evt);
    }
}

using Aworkplace.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aworkplace.Models
{
    public class Literature : ILiterature
    {
        private int? id { get; set; }
        private string? author { get; set; }
        private string? title { get; set; }
        private int? numInstance { get; set; }
        private DateTime? dateOutputLiterature { get; set; }


        public static string pathFile = "../../../Files/Literature.txt";
        public int? ID { get => id; set => id = value; }
        public string? Author { get => author; set => author = value; }
        public string? Title { get => title; set => title = value; }
        public int? COUNT { get => numInstance; set => numInstance = value; }
        public DateTime? DateOutput { get => dateOutputLiterature; set => dateOutputLiterature = value; }


        public Literature() { }
        ~Literature() { }

        public virtual void AddLiterature()
        {
            string lastLine = File.ReadLines(pathFile).Last();
            string[] ident = lastLine.Split(';');
            string literature = (Convert.ToInt32(ident[0]) + 1).ToString() + ";" + author + ";" + title + ";" + numInstance.ToString() + ";" + dateOutputLiterature.ToString() + " 0 undefined\n";
            File.AppendAllText(pathFile, literature);
        }

        public virtual void DeleteLiterature()
        {

            string findstring = "";
            string[] allLiterature = File.ReadAllLines(pathFile);
            foreach (string readerString in allLiterature)
            {
                string[] line = readerString.Split(';');
                if (id == Convert.ToInt32(line[0]))
                {
                    findstring = readerString;
                }
            }
            allLiterature = allLiterature.Where(x => x != findstring).ToArray();
            File.WriteAllLines(pathFile, allLiterature);
        }

        public virtual void UpdateLiterature()
        {
            string[] allReader = File.ReadAllLines(pathFile);

            for (int i = 0; i < allReader.Length; i++)
            {
                string[] line = allReader[0].Split(';');
                if (id == Convert.ToInt32(line[0]))
                {
                    allReader[i] = id.ToString() + ";" + author + ";" + title + ";" + numInstance.ToString() + ";" + dateOutputLiterature.ToString() + " 0 undefined";
                }
            }
            File.WriteAllLines(pathFile, allReader);
        }

        public int getLastId()
        {
            string lastLine = File.ReadLines(pathFile).Last();
            string[] ident = lastLine.Split(';');
            return Convert.ToInt32(ident[0]);
        }
    }
}

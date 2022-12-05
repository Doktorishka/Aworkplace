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


        public int? ID { get => id; set => value = id; }
        public string? Author { get => author; set => value = author; }
        public string? Title { get => title; set => value = title; }
        

        public Literature() { }


        public virtual void AddLiterature()
        {
            string lastLine = File.ReadLines("../../../Files/Literature.txt").Last();
            string[] ident = lastLine.Split(' ');
            string literature = (Convert.ToInt32(ident[0]) + 1).ToString() + " " + author + " " + title + " 0 undefine undefine undefine 2099-12-02 0";
            File.AppendAllText("../../../Files/Literature.txt", literature);
        }

        public virtual void DeleteLiterature()
        {

            string findstring = "";
            string[] allLiterature = File.ReadAllLines("../../../Files/Literature.txt");
            foreach (string readerString in allLiterature)
            {
                string[] line = readerString.Split(' ');
                if (id == Convert.ToInt32(line[0]))
                {
                    findstring = readerString;
                }
            }
            allLiterature = allLiterature.Where(x => x != findstring).ToArray();
            File.WriteAllLines("../../../Files/Literature.txt", allLiterature);
        }

        public virtual void UpdateLiterature()
        {
            string[] allReader = File.ReadAllLines("../../../Files/Literature.txt");

            for (int i = 0; i < allReader.Length; i++)
            {
                string[] line = allReader[0].Split(' ');
                if (id == Convert.ToInt32(line[0]))
                {
                    allReader[i] = id.ToString() + " " + author + " " + title + " 0 undefine undefine undefine 2099-12-02 0";
                }
            }
            File.WriteAllLines("../../../Files/Literature.txt", allReader);
        }
    }
}

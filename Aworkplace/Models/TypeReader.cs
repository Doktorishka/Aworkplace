using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aworkplace.Models
{
    public class TypeReader : Reader
    {
        private int identificatorType { get; set; }
        private string nameType { get; set; }
        private string typeObject { get; set; }

        public int Identificator { get => identificatorType; set =>  identificatorType = value; }
        public string NameType { get => nameType; set => nameType = value; }
        public string TypeObject { get => typeObject; set => typeObject = value; }

        public TypeReader() : base() { }

        public TypeReader(int id, int idCard, string lastName, string firstName, DateTime dateBirth, int ident, string nameType, string typeObject) : base() {
            this.ID = id;
            this.IDReaderCard = idCard;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateBirth = dateBirth;
            this.Identificator = ident;
            this.NameType = nameType;
            this.TypeObject = typeObject;
        }

        public override void AddReader()
        {
            string lastLine = File.ReadLines("../../../Files/Readers.txt").Last();
            string[] ident = lastLine.Split(' ');
            string reader = (Convert.ToInt32(ident[0]) + 1).ToString() + " " + LastName + " " + FirstName + " " + Patronomyc + " " + DateBirth.ToString() + " " + identificatorType.ToString() + " " + typeObject;
            File.AppendAllText("../../../Files/Readers.txt", reader);
        }
        public override void UpdateReader()
        {
            string findstring = "";
            string[] allReader = File.ReadAllLines("../../../Files/Readers.txt");

            for (int i = 0; i < allReader.Length; i++)
            {
                string[] line = allReader[0].Split(' ');
                if (this.ID == Convert.ToInt32(line[0]))
                {
                    allReader[i] = ID.ToString() + " " + LastName + " " + FirstName + " " + Patronomyc + " " + DateBirth.ToString() + " "+identificatorType.ToString() + " " + typeObject;
                }
            }
            File.WriteAllLines("../../../Files/Readers.txt", allReader);
        }
    }
}

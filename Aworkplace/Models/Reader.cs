using Aworkplace.Models.Interfaces;

namespace Aworkplace.Models
{
    public class Reader : IReader
    {
        internal protected int? id { get; protected set; }
        internal protected int? idReaderCard { get; protected set; }
        internal protected string? lastName { get; protected set; }
        internal protected string? firstName { get; protected set; }
        internal protected string? patronomyc { get; protected set; }
        internal protected DateTime? dateBirth { get; protected set; }

        public static string pathFile = "../../../Files/Readers.txt";
        public int? ID { get => id; set => id = value; }
        public int? IDReaderCard { get => idReaderCard; set => idReaderCard = value; }
        public string? FirstName { get => firstName; set =>firstName = value; }
        public string? LastName { get => lastName; set => lastName = value; }
        public string? Patronomyc { get => patronomyc; set => patronomyc = value;  }
        public DateTime? DateBirth { get => dateBirth; set => dateBirth = value; }

        public Reader() { }

        ~Reader() {}

        public Reader(int id, int idCard, string lastName, string firstName, DateTime dateBirth) {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateBirth = dateBirth;
            this.IDReaderCard = idCard;
        }

        public Reader(int id, int idCard, string lastName, string firstName, string patronomyc, DateTime dateBirth)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Patronomyc = patronomyc;
            this.DateBirth = dateBirth;
            this.IDReaderCard = idCard; 
        }

        public virtual void AddReader()
        {
            string lastLine = File.ReadLines("../../../Files/Readers.txt").Last();
            string[] ident = lastLine.Split(';');
            string reader = ("\n" + ID.ToString() + ";" + IDReaderCard.ToString() + ";" + lastName + ";" + firstName + ";" + patronomyc + ";" + dateBirth.Value.ToShortDateString() + " 0 undefine");
            File.AppendAllText("../../../Files/Readers.txt", reader);
        }

        public virtual void DeleteReader()
        {
            string findstring = "";
            string[] allReader = File.ReadAllLines("../../../Files/Readers.txt");
            foreach (string readerString in allReader)
            {
                string[] line = readerString.Split(';');
                if (id == Convert.ToInt32(line[0]))
                {
                    findstring = readerString;
                }
            }
            allReader = allReader.Where(x => x != findstring).ToArray();
            File.WriteAllLines("../../../Files/Readers.txt", allReader);

                string[] allReaderLiterature = File.ReadAllLines("../../../Files/OutputLiterature.txt");
                foreach (var line in allReader)
                {
                    string[] lineSplit = line.Split(';');
                    if (Convert.ToInt32(lineSplit[0]) == ID)
                    {
                        allReader = allReader.Where(x => x != line).ToArray();
                    }
                }
                File.WriteAllLines("../../../Files/OutputLiterature.txt", allReader);
        }

        public virtual void UpdateReader()
        {
            string[] allReader = File.ReadAllLines("../../../Files/Readers.txt");

            for (int i = 0; i < allReader.Length; i++) {
                string[] line = allReader[0].Split(';');
                if (id == Convert.ToInt32(line[0])) {
                    allReader[i] = id.ToString() + ";" + lastName + ";" + firstName + ";" + patronomyc + ";" + dateBirth.Value.ToShortDateString() + " 0 undefine";
                }
            }
            File.WriteAllLines("../../../Files/Readers.txt", allReader);
        }

        public int getLastIndex()
        {
            string lastLine = File.ReadLines("../../../Files/Readers.txt").Last();
            string[] ident = lastLine.Split(';');
            return Convert.ToInt32(ident[0]);
        }
    }
}

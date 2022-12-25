namespace Aworkplace.Models
{
    public class TypeReader : Reader
    {
        private int identificatorType { get; set; }
        private string nameType { get; set; }
        private string typeObject { get; set; }

        public static string pathFile = "../../../Files/TypeReader.txt";
        public int Identificator { get => identificatorType; set =>  identificatorType = value; }
        public string NameType { get => nameType; set => nameType = value; }
        public string TypeObject { get => typeObject; set => typeObject = value; }

        public TypeReader() : base() { }

        public TypeReader(int id, int idCard, string lastName, string firstName, DateTime dateBirth, int ident, string nameType, string typeObject) : base() {
            this.id = id;
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
            string lastLine = File.ReadLines(Reader.pathFile).Last();
            string[] ident = lastLine.Split(';');
            string reader = "\n" + ID.ToString() + ";" + IDReaderCard.ToString() + ";" + LastName + ";" + FirstName + ";" + Patronomyc + ";" + DateBirth.Value.ToShortDateString() + ";" + identificatorType.ToString() + ";" + typeObject;
            File.AppendAllText(Reader.pathFile, reader);
        }
        public override void UpdateReader()
        {
            string[] allReader = File.ReadAllLines(Reader.pathFile);

            for (int i = 0; i < allReader.Length; i++)
            {
                string[] line = allReader[0].Split(';');
                if (this.ID == Convert.ToInt32(line[0]))
                {
                    allReader[i] = "\n" + ID.ToString() + ";" + IDReaderCard.ToString() + ";" + LastName + ";" + FirstName + ";" + Patronomyc + ";" + DateBirth.Value.ToShortDateString() + " "+identificatorType.ToString() + ";" + typeObject;
                }
            }
            File.WriteAllLines(Reader.pathFile, allReader);
        }
    }
}

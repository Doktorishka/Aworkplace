namespace Aworkplace.Models
{
    public class TypeLiterature : Literature
    {
        private int idType { get; set; }
        private string nameType { get; set; }
        private string? whoisAutorPrint { get; set; }

        public static string pathFile = "../../../Files/TypeLiterature.txt";
        public int IdType { get => idType; set => idType = value; }
        public string? NameType { get => nameType; set => nameType = value; }
        public string? WhoisAutorPrint { get => whoisAutorPrint; set =>  whoisAutorPrint = value; }
       

        public TypeLiterature():base() { }

        public override void AddLiterature()
        {
            string lastLine = File.ReadLines(Literature.pathFile).Last();
            string[] ident = lastLine.Split(' ');
            string literature = "\n" + (Convert.ToInt32(ident[0]) + 1).ToString() + " " + Author + " " + Title + " " + COUNT.ToString() + " " + DateOutput.ToString() + " " + idType.ToString() + " " + WhoisAutorPrint;
            File.AppendAllText(Literature.pathFile, literature);
        }

        public override void UpdateLiterature()
        {
            string[] allReader = File.ReadAllLines(Literature.pathFile);

            for (int i = 0; i < allReader.Length; i++)
            {
                string[] line = allReader[0].Split(' ');
                if (ID == Convert.ToInt32(line[0]))
                {
                    allReader[i] = ID.ToString() + " " + Title + " " + Author + " " + COUNT.ToString() + " " + DateOutput.Value.ToShortDateString() + " " + idType.ToString() + " " + WhoisAutorPrint;
                }
            }
            File.WriteAllLines(Literature.pathFile, allReader);
        }

    }
}

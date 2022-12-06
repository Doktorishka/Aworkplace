namespace Aworkplace.Models
{
    public class TypeLiterature : Literature
    {
        private int idType { get; set; }
        private string nameType { get; set; }
        private string? whoisAutorPrint { get; set; }


        public int IdType { get => idType; set => idType = value; }
        public string? NameType { get => nameType; set => nameType = value; }
        public string? WhoisAutorPrint { get => whoisAutorPrint; set =>  whoisAutorPrint = value; }
       

        public TypeLiterature():base() { }

        public override void AddLiterature()
        {
            string lastLine = File.ReadLines("../../../Files/Literature.txt").Last();
            string[] ident = lastLine.Split(' ');
            string literature = "\n" + (Convert.ToInt32(ident[0]) + 1).ToString() + " " + Author + " " + Title + " " + COUNT.ToString() + " " + DateOutput.ToString() + " " + idType.ToString() + " " + WhoisAutorPrint;
            File.AppendAllText("../../../Files/Literature.txt", literature);
        }

        public override void UpdateLiterature()
        {
            string[] allReader = File.ReadAllLines("../../../Files/Literature.txt");

            for (int i = 0; i < allReader.Length; i++)
            {
                string[] line = allReader[0].Split(' ');
                if (ID == Convert.ToInt32(line[0]))
                {
                    allReader[i] = "\n" + ID.ToString() + " " + Author + " " + Title + " " + COUNT.ToString() + " " + DateOutput.ToString() + " " + idType.ToString() + " " + WhoisAutorPrint;
                }
            }
            File.WriteAllLines("../../../Files/Literature.txt", allReader);
        }

    }
}

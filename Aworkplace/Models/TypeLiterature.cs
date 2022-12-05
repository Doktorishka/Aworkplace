namespace Aworkplace.Models
{
    public class TypeLiterature : Literature
    {
        private int idType { get; set; }
        private string nameType { get; set; }
        private string? whoisAutorPrint { get; set; }
        private DateTime? dateOutputLiterature { get; set; }
        private int? numInstance { get; set; }


        public int IdType { get => idType; set => value = idType; }
        public string? NameType { get => nameType; set => value = nameType; }
        public string? WhoisAutorPrint { get => whoisAutorPrint; set => value = whoisAutorPrint; }
        public DateTime? DateOutput { get => dateOutputLiterature; set => value = dateOutputLiterature; }
        public int? COUNT { get => numInstance; set => value = numInstance; }

        public TypeLiterature():base() { }

        public override void AddLiterature()
        {
            throw new NotImplementedException();
        }

        public override void UpdateLiterature()
        {
            string[] allReader = File.ReadAllLines("../../../Files/Literature.txt");

            for (int i = 0; i < allReader.Length; i++)
            {
                string[] line = allReader[0].Split(' ');
                if (ID == Convert.ToInt32(line[0]))
                {
                    allReader[i] = ID.ToString() + " " + Author + " " + Title + " " + idType.ToString() + " " + nameType + " " + whoisAutorPrint + " " + dateOutputLiterature.ToString() + " " + numInstance.ToString();
                }
            }
            File.WriteAllLines("../../../Files/Literature.txt", allReader);
        }

    }
}

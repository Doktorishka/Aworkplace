using Aworkplace.Models;

namespace Aworkplace.Views
{
    public partial class registerReader : Form
    {
        public registerReader()
        {
            InitializeComponent();
            string[] allType = File.ReadAllLines("../../../Files/TypeReader.txt");
            foreach (string type in allType)
            {
                string[] objectType = type.Split(" ");
                typeReader.Items.Add(objectType[1]);
            }
        }

        private bool isValidation()
        {
            bool rule = true;
            if (lastNameReader.Text == null || lastNameReader.Text == String.Empty || lastNameReader.Text == ""){
                errorLabelLastName.Visible = true;
                rule = false;
              }

            if (firstNameReader.Text == null || firstNameReader.Text == String.Empty || firstNameReader.Text == "") {
                errorLabelFirstName.Visible = true;
                rule = false;
            }
            if (dateBirthReader.Text == null || dateBirthReader.Text == String.Empty || dateBirthReader.Text == "") {
                errorLabelDateBirth.Visible = true;
                rule = false;
            }
                
            return rule;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (isValidation())
            {
                errorLabelLastName.Visible = false;
                errorLabelFirstName.Visible = false;
                errorLabelDateBirth.Visible = false;

                if (typeReader.SelectedIndex == -1)
                {
                    try {
                        Reader reader = new Reader();
                        string idre = "";

                        reader.ID = reader.getLastIndex() + 1;

                        idre += DateTime.Now.Year.ToString();
                        idre += DateTime.Now.Month.ToString();
                        idre += DateTime.Now.Day.ToString();
                        idre += reader.ID.ToString();

                        reader.IDReaderCard = Convert.ToInt32(idre);

                        reader.LastName = lastNameReader.Text.Replace(" ", "");
                        reader.FirstName = firstNameReader.Text.Replace(" ", "");
                        reader.DateBirth = dateBirthReader.Value;
                        
                        if (patronomycReader.Text == null ||
                            patronomycReader.Text == String.Empty ||
                            patronomycReader.Text == "")
                            reader.Patronomyc = "undefined";
                        else
                            reader.Patronomyc = patronomycReader.Text.Replace(" ", "");
                        reader.AddReader();
                        MessageBox.Show("Читатель успешно зарегистрирован!");
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    finally{
                        GC.Collect();
                        this.Close();
                    }
                }
                else
                {
                    try{
                        TypeReader reader = new TypeReader();
                        string idre = "";
                        reader.ID = reader.getLastIndex() + 1;

                        idre += DateTime.Now.Year.ToString();
                        idre += DateTime.Now.Month.ToString();
                        idre += DateTime.Now.Day.ToString();
                        idre += reader.ID.ToString();

                        reader.IDReaderCard = Convert.ToInt32(idre);

                        reader.LastName = lastNameReader.Text.Replace(" ", "");
                        reader.FirstName = firstNameReader.Text.Replace(" ", ""); ;
                        reader.DateBirth = dateBirthReader.Value;
                        
                        if (patronomycReader.Text == null ||
                            patronomycReader.Text == String.Empty ||
                            patronomycReader.Text == "")
                            reader.Patronomyc = "undefined";
                        else
                            reader.Patronomyc = patronomycReader.Text.Replace(" ", "");
                        reader.Identificator = typeReader.SelectedIndex + 1;
                        if (typeObjectReader.Text == null ||
                            typeObjectReader.Text == String.Empty ||
                            typeObjectReader.Text == "")
                            reader.TypeObject = "undefined";
                        else
                            reader.TypeObject = typeObjectReader.Text;
                        reader.AddReader();
                        MessageBox.Show("Читатель успешно зарегистрирован!");
                    }
                    catch(Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    finally {
                        GC.Collect();
                        this.Close();
                    }
                }
            }
            else {
                MessageBox.Show("Заполните обязательные поля!");
            }
        }
    }
}

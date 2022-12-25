using Aworkplace.Models;

namespace Aworkplace.Views
{
    public partial class registerReader : Form
    {
        Functions f = new Functions();

        public registerReader()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            string[] allType = File.ReadAllLines("../../../Files/TypeReader.txt");
            foreach (string type in allType)
            {
                string[] objectType = type.Split(";");
                typeReader.Items.Add(objectType[1]);
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (f.isValidation(lastNameReader.Text, firstNameReader.Text, dateBirthReader.Text))
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
                errorLabelLastName.Visible = true;
                errorLabelFirstName.Visible = true;
                errorLabelDateBirth.Visible = true;
                MessageBox.Show("Заполните обязательные поля!");
            }
        }

        private void function_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else e.Handled = true;
        }

        private void registerReader_Load(object sender, EventArgs e)
        {

        }
    }
}

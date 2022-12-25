using Aworkplace.Views;

namespace Aworkplace
{
    public partial class StartedForm : Form
    {
        public StartedForm()
        {
            InitializeComponent();
        }
        private void registerReaderFromButton_Click(object sender, EventArgs e)
        {
            registerReader rr = new registerReader();
            
            rr.Show();
            
        }

        private void listingReaderFromButton_Click(object sender, EventArgs e)
        {
            listReaders lr = new listReaders();

            lr.Show();
        }

        private void registerBookFromButton_Click(object sender, EventArgs e)
        {
            registerLiterature rl = new registerLiterature();

            rl.Show();
        }

        private void listingBookFromButton_Click(object sender, EventArgs e)
        {
            listLiterature ll = new listLiterature();

            ll.Show();
        }

        private void issueBookFormButton_Click(object sender, EventArgs e)
        {
            outputLiteratureForReader outputLiteratureForReader = new outputLiteratureForReader();
            outputLiteratureForReader.Show();
        }

        private void acceptBookFormButton_Click(object sender, EventArgs e)
        {
            inputLiteratureFromReader ilr = new inputLiteratureFromReader();
            ilr.Show();
        }

        private void listingDebtorFromButton_Click(object sender, EventArgs e)
        {
            listDebtorReader ldr = new listDebtorReader();

            ldr.Show();
        }

        private void usedBookFromButton_Click(object sender, EventArgs e)
        {
            listInputLiterature list = new listInputLiterature();

            list.ShowDialog();

            if (list.DialogResult == DialogResult.) { 
                
            }
        }
    }
}
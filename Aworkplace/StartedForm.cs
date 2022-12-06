using Aworkplace.Models;
using Aworkplace.Views;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace Aworkplace
{
    public partial class StartedForm : Form
    {
        public StartedForm()
        {
            InitializeComponent();
        }
        private async void registerReaderFromButton_Click(object sender, EventArgs e)
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
    }
}
using Aworkplace.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aworkplace.Views
{
    public partial class registerLiterature : Form
    {
        Functions f = new Functions();

        public registerLiterature()
        {
            InitializeComponent();
            string[] allType = File.ReadAllLines("../../../Files/TypeLiterature.txt");
            foreach (string type in allType)
            {
                string[] objectType = type.Split(" ");
                typeLiterature.Items.Add(objectType[1]);
            }

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (f.isValidation(countLinerature.Value, nameLiterature.Text, nameAuthor.Text, datePublish.Text)){
                errorLabelLastName.Visible = false;
                errorLabelFirstName.Visible = false;
                errorLabelDateBirth.Visible = false;

                if (typeLiterature.SelectedIndex == -1)
                {
                    try
                    {
                        Literature literature = new Literature();

                        literature.ID = literature.getLastId() + 1;
                        literature.Title = nameLiterature.Text;
                        literature.Author = nameAuthor.Text;
                        literature.COUNT = (int?)countLinerature.Value;
                        literature.DateOutput = datePublish.Value;

                        literature.AddLiterature();
                        MessageBox.Show("Читатель успешно зарегистрирован!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        GC.Collect();
                        this.Close();
                    }
                }
                else {
                    try
                    {
                        TypeLiterature literature = new TypeLiterature();

                        literature.ID = literature.getLastId() + 1;
                        literature.Title = nameLiterature.Text;
                        literature.Author = nameAuthor.Text;
                        literature.COUNT = (int?)countLinerature.Value;
                        literature.DateOutput = datePublish.Value;

                        literature.IdType = typeLiterature.SelectedIndex;
                        literature.WhoisAutorPrint = typeObjectLiterature.Text;
                        literature.AddLiterature();
                        MessageBox.Show("Читатель успешно зарегистрирован!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
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

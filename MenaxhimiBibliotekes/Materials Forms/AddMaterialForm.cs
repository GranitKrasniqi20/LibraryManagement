using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.Materials_Forms
{
    public partial class AddMaterialForm : Form
    {
        //Global Variables and Instances
        ErrorProvider errorProvider;

        public AddMaterialForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }



        //Customized Methods
        private void MultipleAuthors(string myTextbox, string[] authorsContainer)
        {
            authorsContainer = myTextbox.Split('/');
        }




        // Events
        private void comboMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMaterialType.SelectedItem == "Other")
            {
                InsertNewMaterialType materialtypeForm = new InsertNewMaterialType();
                materialtypeForm.ShowDialog();
            }
        }

        private void comboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGenre.SelectedItem == "Other")
            {
                InsertNewGenre genreForm = new InsertNewGenre();
                genreForm.ShowDialog();
            }
        }

        private void comboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLanguage.SelectedItem == "Other")
            {
                InsertNewLanguage languageForm = new InsertNewLanguage();
                languageForm.ShowDialog();
            }
        }

        private void AddMaterialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTitle.Text != "" ||
                comboMaterialType.SelectedIndex != -1 ||
                txtAuthor.Text != "" ||
                comboGenre.SelectedIndex != -1 ||
                comboLanguage.SelectedIndex != -1 ||
                txtISBN.Text != "" ||
                txtPublishHouse.Text != "" ||
                txtPublishDate.Text != "" ||
                txtPublishPlace.Text != "" ||
                txtQuantity.Text != "" ||
                txtPages.Text != "")
            {
                DialogResult dialog = MessageBox.Show("You've made some changes in the form. Are you sure you want to close?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //string[] myAuthors = new string[5];
            

            //foreach (var item in myAuthors)
            //{
            //    MessageBox.Show(item);
            //}
            try
            {
                string authorTextbox = txtAuthor.Text;
                string[] myAuthors = authorTextbox.Split('/');

                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    MessageBox.Show("The material is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtTitle, "Please enter Title!");
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(txtTitle, null);
            }
        }
    }
}

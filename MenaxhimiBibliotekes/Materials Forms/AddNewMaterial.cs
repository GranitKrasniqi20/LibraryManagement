using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BLL.Validate;
using MenaxhimiBibliotekes.BO;

namespace MenaxhimiBibliotekes.Materials_Forms
{
    public partial class AddNewMaterial : Form
    {
        //Global Variables and Instances
        Material material;
        MaterialBLL materialBLL;

        MaterialTypeBLL materialtypeBllList;
        List<MaterialType> materialtypeList;

        GenreBLL genreBllList;
        List<Genre> genreList;

        LanguageBLL languageBllList;
        List<Language> languageList;

        ShelfBLL shelfBLLList;
        List<Shelf> shelfList;

        public AddNewMaterial()
        {
            InitializeComponent();

            //Combobox GENRE fill
            comboGenre.Items.Clear();

            genreBllList = new GenreBLL();
            genreList = genreBllList.GetAll();
            comboGenre.Items.Add("Other");

            foreach (var item in genreList)
            {
                comboGenre.Items.Add(item._Genre);
            }


            //Combobox MATERIAL TYPE fill
            comboMaterialType.Items.Clear();

            materialtypeBllList = new MaterialTypeBLL();
            materialtypeList = materialtypeBllList.GetAll();
            comboMaterialType.Items.Add("Other");

            foreach (var item in materialtypeList)
            {
                comboMaterialType.Items.Add(item._MaterialType);
            }


            //Combobox LANGUAGES fill
            comboLanguage.Items.Clear();

            languageBllList = new LanguageBLL();
            languageList = languageBllList.GetAll();
            comboLanguage.Items.Add("Other");

            foreach (var item in languageList)
            {
                comboLanguage.Items.Add(item._Language);
            }


            //Combobox MATERIAL LOCATION fill
            comboMaterialLocation.Items.Clear();

            shelfBLLList = new ShelfBLL();
            shelfList = shelfBLLList.GetAll();
            comboMaterialLocation.Items.Add("Other");

            foreach (var item in shelfList)
            {
                comboMaterialLocation.Items.Add(item.Location);
            }


        }





        //Customized Methods
        private void MultipleAuthors(string myTextbox, string[] authorsContainer)
        {
            authorsContainer = myTextbox.Split('/');
        }

        private void DisabledByMaterialType (Control title, Control author, Control genre, Control language, Control isbn, Control location, Control publish_house, Control publish_date, Control publish_place, Control quantity, Control pages)
        {
            title.Enabled = false;
            author.Enabled = false;
            genre.Enabled = false;
            language.Enabled = false;
            isbn.Enabled = false;
            location.Enabled = false;
            publish_house.Enabled = false;
            publish_date.Enabled = false;
            publish_place.Enabled = false;
            quantity.Enabled = false;
            pages.Enabled = false;
        }

        private void EnabledByMaterialType(Control title, Control author, Control genre, Control language, Control isbn, Control location, Control publish_house, Control publish_date, Control publish_place, Control quantity, Control pages)
        {
            title.Enabled = true;
            author.Enabled = true;
            genre.Enabled = true;
            language.Enabled = true;
            isbn.Enabled = true;
            location.Enabled = true;
            publish_house.Enabled = true;
            publish_date.Enabled = true;
            publish_place.Enabled = true;
            quantity.Enabled = true;
            pages.Enabled = true;
        }







        //Events
        private void comboMaterialType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboMaterialType.SelectedItem == "Other")
            {
                InsertNewMaterialType materialtypeForm = new InsertNewMaterialType();
                materialtypeForm.ShowDialog();

                DisabledByMaterialType(txtTitle, txtAuthor, comboGenre, comboLanguage, txtISBN, comboMaterialLocation, txtPublishHouse, txtPublishDate, txtPublishPlace, txtQuantity, txtPages);

            }
            else if (comboMaterialType.SelectedItem == "Book")
            {
                EnabledByMaterialType(txtTitle, txtAuthor, comboGenre, comboLanguage, txtISBN, comboMaterialLocation, txtPublishHouse, txtPublishDate, txtPublishPlace, txtQuantity, txtPages);
            }
            else
            {
                EnabledByMaterialType(txtTitle, txtAuthor, comboGenre, comboLanguage, txtISBN, comboMaterialLocation, txtPublishHouse, txtPublishDate, txtPublishPlace, txtQuantity, txtPages);
                
                txtISBN.Enabled = false;
            }
        }

        private void comboGenre_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboGenre.SelectedItem == "Other")
            {
                InsertNewGenre genreForm = new InsertNewGenre();
                genreForm.ShowDialog();
            }
        }

        private void comboLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboLanguage.SelectedItem == "Other")
            {
                InsertNewLanguage languageForm = new InsertNewLanguage();
                languageForm.ShowDialog();
            }
        }

        private void AddNewMaterial_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                material = new Material();
                materialBLL = new MaterialBLL();

                //DateTime d = new DateTime();

                material.Title = txtTitle.Text;
                material._Author.AuthorName = txtAuthor.Text;

                foreach (var item in genreList)
                {
                    if (item._Genre == comboGenre.SelectedItem.ToString())
                    {
                        material._Genre.GenreId = item.GenreId;
                        material.GenreId = item.GenreId;
                    }
                }

                foreach (var item in languageList)
                {
                    if (item._Language == comboLanguage.SelectedItem.ToString())
                    {
                        material._Language.LanguageId = item.LanguageId;
                        material.LanguageId = item.LanguageId;
                    }
                }

                //bool isISBNvalid = Regex.IsMatch(txtISBN.Text, "^\\d{13}$");

                //if (txtISBN.Text != "")
                //{
                //    if (txtISBN.Text.Length != 13)
                //    {
                //        MessageBox.Show($"Length of ISBN should be exact 13!", "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //    }
                //    else if (!isISBNvalid)
                //    {
                //        MessageBox.Show($"Please enter only digit numbers for ISBN!", "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //    else
                //    {
                //        material.ISBN = txtISBN.Text;
                //    }
                //}
                //else
                //{
                //    material.ISBN = "";
                //}

                foreach (var item in shelfList)
                {
                    if (item.Location == comboMaterialLocation.SelectedItem.ToString())
                    {
                        material._Shelf.ShelfId = item.ShelfId;
                        material.ShelfId = item.ShelfId;
                    }
                }

                foreach (var item in materialtypeList)
                {
                    if (item._MaterialType == comboMaterialType.SelectedItem.ToString())
                    {
                        material._MaterialType.MaterialTypeId = item.MaterialTypeId;
                        material.MaterialTypeId = item.MaterialTypeId;
                    }
                }

                //if (txtPublishHouse.Text != "")
                //{
                //    if (txtPublishHouse.Text.Length < 2 || txtPublishHouse.Text.Length > 50)
                //    {
                //        MessageBox.Show($"Publish House Length is not acceptable. Lower than 50 and greater than 3 characters!", "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //    else
                //    {
                //        material._PublishHouse._PublishHouse = txtPublishHouse.Text;
                //    }
                //}
                //else
                //{
                //    material._PublishHouse._PublishHouse = "";
                //}

                int n;
                bool isNumeric = int.TryParse(txtPublishDate.Text, out n);
                if (isNumeric)
                {
                    //d = new DateTime(int.Parse(txtPublishDate.Text), 1, 1);
                    //material.PublishYear = Convert.ToDateTime(d.Year);
                    //string gg = material.PublishYear.ToShortDateString(); 

                    material.PublishYear = new DateTime(int.Parse(txtPublishDate.Text), 1, 1);
                }


                //if (txtPublishPlace.Text != "")
                //{

                //}

                material.PublishPlace = txtPublishPlace.Text;

                material.Quantity = Convert.ToInt32(txtQuantity.Text);

                material.NumberOfPages = Convert.ToInt32(txtPages.Text);

                material.IsActive = true;

                material.InsBy = FormLoggedUser.Id;



                MaterialValidation materialValidator = new MaterialValidation();

                ValidationResult results = materialValidator.Validate(material);


                if (results.IsValid == false)
                {
                    foreach (ValidationFailure failure in results.Errors)
                    {
                        MessageBox.Show($"{failure.ErrorMessage}", "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    materialBLL.Add(material);
                    MessageBox.Show("The material is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtTitle_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                txtTitle.Text = $"{lblTitle.Text} should not be empty";
                txtTitle.ForeColor = Color.DarkRed;
            }
        }

        private void txtTitle_Enter_1(object sender, EventArgs e)
        {
            if (txtTitle.Text == $"{lblTitle.Text} should not be empty")
            {
                txtTitle.Text = string.Empty;
                txtTitle.ForeColor = Color.Gray;
            }
        }

        private void txtAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                txtAuthor.Text = $"{lblAuthor.Text} should not be empty";
                txtAuthor.ForeColor = Color.DarkRed;
            }
        }

        private void txtAuthor_Enter(object sender, EventArgs e)
        {
            if (txtAuthor.Text == $"{lblAuthor.Text} should not be empty")
            {
                txtAuthor.Text = string.Empty;
                txtAuthor.ForeColor = Color.Gray;
            }
        }

        private void txtPublishHouse_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPublishHouse.Text))
            {
                txtPublishHouse.Text = $"{lblPublishHouse.Text} should not be empty";
                txtPublishHouse.ForeColor = Color.DarkRed;
            }
        }

        private void txtPublishHouse_Enter(object sender, EventArgs e)
        {
            if (txtPublishHouse.Text == $"{lblPublishHouse.Text} should not be empty")
            {
                txtPublishHouse.Text = string.Empty;
                txtPublishHouse.ForeColor = Color.Gray;
            }
        }

        private void txtPublishDate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPublishDate.Text))
            {
                txtPublishDate.Text = $"{lblPublishDate.Text} should not be empty";
                txtPublishDate.ForeColor = Color.DarkRed;
            }
        }

        private void txtPublishDate_Enter(object sender, EventArgs e)
        {
            if (txtPublishDate.Text == $"{lblPublishDate.Text} should not be empty")
            {
                txtPublishDate.Text = string.Empty;
                txtPublishDate.ForeColor = Color.Gray;
            }
        }

        private void txtPublishPlace_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPublishPlace.Text))
            {
                txtPublishPlace.Text = $"{lblPublishPlace.Text} should not be empty";
                txtPublishPlace.ForeColor = Color.DarkRed;
            }
        }

        private void txtPublishPlace_Enter(object sender, EventArgs e)
        {
            if (txtPublishPlace.Text == $"{lblPublishPlace.Text} should not be empty")
            {
                txtPublishPlace.Text = string.Empty;
                txtPublishPlace.ForeColor = Color.Gray;
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                txtQuantity.Text = $"{lblPublishDate.Text} should not be empty";
                txtQuantity.ForeColor = Color.DarkRed;
            }
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        bool openFormG, openFormL, openFormSH, openFormMT;

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
            openFormG = openFormL = openFormSH = openFormMT = false;


            //Combobox GENRE fill
            BindGenre();
            //Combobox LANGUAGES fill
            BindLanguage();
            //Combobox MATERIAL TYPE fill
            BindMaterialType();
            //Combobox MATERIAL LOCATION fill
            BindShelf();
        }
        private void BindLanguage()
        {

            languageBllList = new LanguageBLL();
            Language l = new Language();
            languageList = languageBllList.GetAll();
            l = languageList[0];
            languageList[0] = new Language() { LanguageId = 0, _Language = "Other" };
            languageList.Add(l);
            comboLanguage.DataSource = languageList;
            comboLanguage.DisplayMember = "_Language";
        }
        private void BindGenre()
        {

            genreBllList = new GenreBLL();
            Genre g = new Genre();
            genreList = genreBllList.GetAll();
            g = genreList[0];
            genreList[0] = new Genre() { GenreId = 0, _Genre = "Other" };
            genreList.Add(g);

            comboGenre.DataSource = genreList;
            comboGenre.DisplayMember = "_Genre";
        }
        private void BindShelf()
        {

            shelfBLLList = new ShelfBLL();
            Shelf sh = new Shelf();
            shelfList = shelfBLLList.GetAll();
            sh = shelfList[0];
            shelfList[0] = new Shelf() { ShelfId = 0, Location = "Other" };
            shelfList.Add(sh);
            comboMaterialLocation.DataSource = shelfList;
            comboMaterialLocation.DisplayMember = "Location";
        }

        private void BindMaterialType()
        {
            

            materialtypeBllList = new MaterialTypeBLL();
            MaterialType mt = new MaterialType();
            materialtypeList = materialtypeBllList.GetAll();
            mt = materialtypeList[0];
            materialtypeList[0] = new MaterialType() { MaterialTypeId = 0, _MaterialType = "Other" };
            materialtypeList.Add(mt);

            comboMaterialType.DataSource = materialtypeList;
            comboMaterialType.DisplayMember = "_MaterialType";
        }


        //Customized Methods
        private void MultipleAuthors(string myTextbox, string[] authorsContainer)
        {
            authorsContainer = myTextbox.Split('/');
        }

        private void DisabledByMaterialType (Control title, Control author, Control genre, Control language, Control isbn, Control location, Control publish_house, Control publish_date, Control quantity, Control pages)
        {
            title.Enabled = false;
            author.Enabled = false;
            genre.Enabled = false;
            language.Enabled = false;
            isbn.Enabled = false;
            location.Enabled = false;
            publish_house.Enabled = false;
            publish_date.Enabled = false;
            quantity.Enabled = false;
            pages.Enabled = false;
        }

        private void EnabledByMaterialType(Control title, Control author, Control genre, Control language, Control isbn, Control location, Control publish_house, Control publish_date, Control quantity, Control pages)
        {
            title.Enabled = true;
            author.Enabled = true;
            genre.Enabled = true;
            language.Enabled = true;
            isbn.Enabled = true;
            location.Enabled = true;
            publish_house.Enabled = true;
            publish_date.Enabled = true;
            quantity.Enabled = true;
            pages.Enabled = true;
        }







        //Events
        private void comboMaterialType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MaterialType cmt = comboMaterialType.SelectedItem as MaterialType;

            if (cmt.MaterialTypeId == 0)
            {
                if (openFormMT)
                {
                    openFormMT = false;
                    MaterialTypeForm materialtypeForm = new MaterialTypeForm();
                    materialtypeForm.ShowDialog();
                    BindMaterialType();
                    DisabledByMaterialType(txtTitle, txtAuthor, comboGenre, comboLanguage, txtISBN, comboMaterialLocation, txtPublishHouse, txtPublishDate, txtQuantity, txtPages);

                }



                else
                {
                    openFormMT = true;
                }

            }
            else
            {
                EnabledByMaterialType(txtTitle, txtAuthor, comboGenre, comboLanguage, txtISBN, comboMaterialLocation, txtPublishHouse, txtPublishDate, txtQuantity, txtPages);
            }
        }



        private void comboGenre_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            Genre cg = comboGenre.SelectedItem as Genre;

            if (cg.GenreId == 0)
            {
                if (openFormG)
                {
                    openFormG = true;
                    GenreForm genreForm = new GenreForm();
                    genreForm.ShowDialog();
                    BindGenre();
                }
                else
                {
                    openFormG = false;
                }
                
            }

        }

        private void comboLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Language cl = comboLanguage.SelectedItem as Language;

            if (cl.LanguageId == 0)
            {
                if (openFormL)
                {
                    openFormL = true;
                    LanguageForm languageForm = new LanguageForm();
                    languageForm.ShowDialog();
                    BindLanguage();
                }
                else
                {
                    openFormL = false;
                }
            }
        }

        private void comboMaterialLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shelf cml = comboMaterialLocation.SelectedItem as Shelf;

            if (cml.ShelfId == 0)
            {
                if (openFormSH)
                {
                    openFormSH = true;
                    MaterialLocation locationForm = new MaterialLocation();
                    locationForm.ShowDialog();
                    BindShelf();
                }
                else
                {
                    openFormSH = false;
                }

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

             // ------------------------------ //

                material.Title = txtTitle.Text;
                material._Author.AuthorName = txtAuthor.Text;

                Genre gen = getGenre();
                material._Genre = gen;
                material.GenreId = gen.GenreId;

                Language lang = getLanguange();
                material._Language = lang;
                material.LanguageId = lang.LanguageId;

                material.ISBN =txtISBN.Text;

                material._PublishHouse._PublishHouse = txtPublishHouse.Text;

                Shelf shelf = getShelf();
                material._Shelf = shelf;
                material.ShelfId = shelf.ShelfId;

                MaterialType materialtype = getMaterialType();
                material._MaterialType = materialtype;
                material.MaterialTypeId = materialtype.MaterialTypeId;

                int n;
                bool isNumeric = int.TryParse(txtPublishDate.Text, out n);
                if (isNumeric)
                {
                    //d = new DateTime(int.Parse(txtPublishDate.Text), 1, 1);
                    //material.PublishYear = Convert.ToDateTime(d.Year);
                    //string gg = material.PublishYear.ToShortDateString(); 

                    material.PublishYear = new DateTime(int.Parse(txtPublishDate.Text), 1, 1);
                }

                material.Quantity = Convert.ToInt32(txtQuantity.Text);

                material.NumberOfPages = Convert.ToInt32(txtPages.Text);

                material.IsActive = true;

                material.InsBy = FormLoggedUser.Id;




                MaterialValidation materialValidator = new MaterialValidation();

                materialValidator.material = material;

                materialValidator.ValidateMaterial();

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
                    
                    if (materialBLL.Add(material) == 0)
                    {
                        MessageBox.Show("The material is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        throw new Exception();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Material is not inserted please contact your adminsitrator");
            }
        }

        public Shelf getShelf()
        {
            return comboMaterialLocation.SelectedItem as Shelf;
        }

        public MaterialType getMaterialType()
        {
            return comboMaterialType.SelectedItem as MaterialType;
        }

        public Language getLanguange()
        {
            return comboLanguage.SelectedItem as Language;
        }

        public Genre getGenre()
        {
            return comboGenre.SelectedItem as Genre;
        }


        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

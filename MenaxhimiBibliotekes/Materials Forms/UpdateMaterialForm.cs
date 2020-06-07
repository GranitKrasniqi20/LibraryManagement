using FluentValidation.Results;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BLL.Validate;
using MenaxhimiBibliotekes.BO;
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
    public partial class UpdateMaterialForm : Form
    {
        //Global Variables and Instances
        bool openFormG, openFormL, openFormSH, openFormMT;
        bool isActiveMaterial;


        Material material;


        MaterialBLL mbll;

        MaterialTypeBLL materialtypeBllList;
        List<MaterialType> materialtypeList;



        GenreBLL genreBllList;
        List<Genre> genreList;

        LanguageBLL languageBllList;
        List<Language> languageList;

        ShelfBLL shelfBLLList;
        List<Shelf> shelfList;


        public UpdateMaterialForm()
        {
            InitializeComponent();

            openFormG = openFormL = openFormSH = openFormMT = false;


            material = new Material();
            mbll = new MaterialBLL();



            comboMaterialType.Items.Clear();
            BindDropDownGenre(new Genre() { GenreId = 0, _Genre = "Other" });
                         comboMaterialType.Items.Clear();
            BindDropdownMaterialType(new MaterialType() { MaterialTypeId = 0, _MaterialType = "Other" });
            comboMaterialLocation.Items.Clear();
            BindDrobdownMaterialLocation(new Shelf() { ShelfId = 0, Location = "Other" });
            comboLanguage.Items.Clear();
            BindDrobdownLanguage(new Language() { LanguageId = 0, _Language = "Other" });


        }


        private void BindDropDownGenre(Genre first)
        {


            genreBllList = new GenreBLL();
            Genre g = new Genre();
            genreList = genreBllList.GetAll();


            foreach (var item in genreList)
            {
                if (first.GenreId == item.GenreId)
                {
                    g = item;
                }
            }

            genreList.Remove(g);
            g = genreList[0];
            genreList[0] = first;
            genreList.Add(g);
            comboGenre.DataSource = genreList;
            comboGenre.DisplayMember = "_Genre";
        }
        public void BindDropdownMaterialType(MaterialType first)
        {

            materialtypeBllList = new MaterialTypeBLL();
            MaterialType mt = new MaterialType();
            materialtypeList = materialtypeBllList.GetAll();

            foreach (var item in materialtypeList)
            {
                if (first.MaterialTypeId == item.MaterialTypeId)
                {
                    mt = item;
                }
            }
            materialtypeList.Remove(mt);

            mt = new MaterialType();
            mt = materialtypeList[0];
            materialtypeList[0] = first;
            materialtypeList.Add(mt);
            comboMaterialType.DataSource = materialtypeList;
            comboMaterialType.DisplayMember = "_MaterialType";
        }
        public void BindDrobdownMaterialLocation(Shelf first)
        {
            //Combobox MATERIAL LOCATION fill

            shelfBLLList = new ShelfBLL();
            Shelf sh = new Shelf();
            shelfList = shelfBLLList.GetAll();
            foreach (var item in shelfList)
            {
                if (first.ShelfId == item.ShelfId)
                {
                    sh = item;
                }
            }
            shelfList.Remove(sh);
            sh = new Shelf();
            sh = shelfList[0];
            shelfList[0] = first;
            shelfList.Add(sh);
            comboMaterialLocation.DataSource = shelfList;
            comboMaterialLocation.DisplayMember = "Location";
        }

        public void BindDrobdownLanguage(Language first)
        {
            languageBllList = new LanguageBLL();
            Language l = new Language();
            languageList = languageBllList.GetAll();
            foreach (var item in languageList)
            {
                if (first.LanguageId == item.LanguageId)
                {
                    l = item;
                }
            }
            languageList.Remove(l);
             l = new Language();
            l = languageList[0];
            languageList[0] = first;
            languageList.Add(l);
            comboLanguage.DataSource = languageList;
            comboLanguage.DisplayMember = "_Language";
        }





        private void DisabledByMaterialType(Control title, Control author, Control genre, Control language, Control isbn, Control location, Control publish_house, Control publish_date, Control quantity, Control pages)
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









        //Events
        private void comboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genre cg = comboGenre.SelectedItem as Genre;

            if (cg.GenreId == 0)
            {
                if (openFormG)
                {
                    GenreForm genreForm = new GenreForm();
                    genreForm.ShowDialog();
                }

                openFormG = true;

            }
        }

        private void comboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language cl = comboLanguage.SelectedItem as Language;

            if (cl.LanguageId == 0)
            {
                if (openFormL)
                {
                    LanguageForm languageForm = new LanguageForm();
                    languageForm.ShowDialog();
                }
                openFormL = true;
            }
        }

        private void comboMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialType cmt = comboMaterialType.SelectedItem as MaterialType;

            if (cmt.MaterialTypeId == 0)
            {
                if (openFormMT)
                {
                    MaterialTypeForm materialtypeForm = new MaterialTypeForm();
                    materialtypeForm.ShowDialog();

                    DisabledByMaterialType(txtTitle, txtAuthor, comboGenre, comboLanguage, txtISBN, comboMaterialLocation, txtPublishHouse, txtPublishDate, txtQuantity, txtPages);
                }
                openFormMT = true;
            }
            else
            {
                EnabledByMaterialType(txtTitle, txtAuthor, comboGenre, comboLanguage, txtISBN, comboMaterialLocation, txtPublishHouse, txtPublishDate, txtQuantity, txtPages);
            }
        }

        private void comboMaterialLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shelf cml = comboMaterialLocation.SelectedItem as Shelf;

            if (cml.ShelfId == 0)
            {
                if (openFormSH)
                {
                    MaterialLocation locationForm = new MaterialLocation();
                    locationForm.ShowDialog();
                }
                openFormSH = true;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSearchUser_Click(object sender, EventArgs e)
        {

            mbll = new MaterialBLL();
            material = new Material();

            int n;
            bool isNumeric = int.TryParse(txtMaterialID.Text, out n);

            if (isNumeric)
            {
                material = mbll.Get(n);
            }

            if (material != null)
            {
                txtTitle.Text = material.Title;

                txtAuthor.Text = material._Author.AuthorName;
                if (material.ISBN != string.Empty || material.ISBN.Length != null)
                {
                    txtISBN.Text = material.ISBN;
                }

                txtPages.Text = material.NumberOfPages.ToString();

                if (true)
                {
                    txtPublishDate.Text = material.PublishYear.Year.ToString();
                }


                if (material._PublishHouse._PublishHouse != string.Empty || material._PublishHouse._PublishHouse != null)
                {
                    txtPublishHouse.Text = material._PublishHouse._PublishHouse;
                }


                txtQuantity.Text = material.Quantity.ToString();

                if (material.IsActive == true)
                {
                    comboActiveMaterial.SelectedIndex = 0;
                }
                else
                {
                    comboActiveMaterial.SelectedIndex = 1;
                }

                BindDropDownGenre(material._Genre);
                BindDropdownMaterialType(material._MaterialType);
                BindDrobdownMaterialLocation(material._Shelf);
                BindDrobdownLanguage(material._Language);

            }
        }


        

        private void TableHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateMaterialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTitle.Text != "" ||
                comboMaterialType.SelectedIndex != -1 ||
                txtAuthor.Text != "" ||
                comboGenre.SelectedIndex != -1 ||
                comboLanguage.SelectedIndex != -1 ||
                txtISBN.Text != "" ||
                txtPublishHouse.Text != "" ||
                txtPublishDate.Text != "" ||
                comboActiveMaterial.SelectedIndex != -1 ||
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

        private void comboActiveMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboActiveMaterial.SelectedItem == "Active")
            {
                isActiveMaterial = true;
            }
            else
            {
                isActiveMaterial = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                mbll = new MaterialBLL();

                // ------------------------------ //
                material.MaterialId = int.Parse(txtMaterialID.Text);
                material.Title = txtTitle.Text;
                material._Author.AuthorName = txtAuthor.Text;

                Genre gen = getGenre();
                material._Genre = gen;
                material.GenreId = gen.GenreId;

                Language lang = getLanguange();
                material._Language = lang;
                material.LanguageId = lang.LanguageId;

                material.ISBN = txtISBN.Text;

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

                material.IsActive = isActiveMaterial;

                material.UpdBy = FormLoggedUser.Id;




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

                    if (mbll.Update(material) == 1)
                    {
                        MessageBox.Show("The material is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mbll = new MaterialBLL();
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Material is not updated please contact your adminsitrator");
                mbll = new MaterialBLL();
            }


        }

        public void deleteGenreFromList(int GenreId)
        {

        }
        private void txtMaterialID_TextChanged(object sender, EventArgs e)
        {






        }

    }



}



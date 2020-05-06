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
    public partial class MaterialLocation : Form
    {
        //Global Variables
        Shelf shelf;
        ShelfBLL shelfBLL;
        List<Shelf> storedShelf;

        public MaterialLocation()
        {

            InitializeComponent();

            shelf = new Shelf();
            shelfBLL = new ShelfBLL();
            storedShelf = new List<Shelf>();
        }


        //Customized
        //public Shelf getShelf()
        //{
        //    return comboMaterialLocation.SelectedItem as Shelf;
        //}

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                shelf.Location = txtCreateMaterialLocation.Text;
                shelf.Quantity = Convert.ToInt32(txtCreateShelfQuantity.Text);
                shelf.Description = richCreateDescription.Text;
                shelf.InsBy = FormLoggedUser.Id;

                ShelfValidation shelfValidator = new ShelfValidation();

                ValidationResult results = shelfValidator.Validate(shelf);

                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in results.Errors)
                    {
                        MessageBox.Show($"{failure.ErrorMessage}", "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    shelfBLL.Add(shelf);
                    MessageBox.Show("The Shelf is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateSearchLocation_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUpdateSearch.Text != string.Empty)
                {
                    storedShelf = shelfBLL.GetAll();

                    foreach (var specifiedShelf in storedShelf)
                    {
                        if (specifiedShelf.Location == txtUpdateSearch.Text)
                        {
                            shelf = specifiedShelf;
                        }
                    }

                    //shelf = shelfBLL.Get(Convert.ToInt32(txtUpdateSearch.Text));

                    txtUpdateMaterialLocation.Text = shelf.Location;
                    txtUpdateShelfQuantity.Text = shelf.Quantity.ToString();
                    richUpdateDescription.Text = shelf.Description;
                }
                else
                {
                    txtUpdateMaterialLocation.Text = string.Empty;
                    txtUpdateShelfQuantity.Text = string.Empty;
                    richUpdateDescription.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                shelf.Location = txtUpdateMaterialLocation.Text;
                shelf.Quantity = Convert.ToInt32(txtUpdateShelfQuantity.Text);
                shelf.Description = richUpdateDescription.Text;
                shelf.UpdBy = FormLoggedUser.Id;

                ShelfValidation shelfValidator = new ShelfValidation();

                ValidationResult results = shelfValidator.Validate(shelf);

                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in results.Errors)
                    {
                        MessageBox.Show($"{failure.ErrorMessage}", "Error Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    shelfBLL.Update(shelf);
                    MessageBox.Show("The Shelf is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}

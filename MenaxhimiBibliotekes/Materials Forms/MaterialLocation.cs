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
                shelf.Location = txtMaterialLocationCreate.Text;
                shelf.Quantity = Convert.ToInt32(txtShelfQuantityCreate.Text);
                shelf.Description = richLocationDescriptionCreate.Text;
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
                    int error = shelfBLL.Add(shelf);
                    if (error == 0)
                    {
                        MessageBox.Show("The Shelf is registered successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("This Shelf is already registered!", "This Exists!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchMaterialLocationUpdate.Text != string.Empty)
                {
                    storedShelf = shelfBLL.GetAll();

                    foreach (var specifiedShelf in storedShelf)
                    {
                        if (specifiedShelf.Location == txtSearchMaterialLocationUpdate.Text)
                        {
                            shelf = specifiedShelf;
                        }
                    }

                    txtMaterialLocationUpdate.Text = shelf.Location;
                    txtShelfQuantityUpdate.Text = shelf.Quantity.ToString();
                    richLocationDescriptionUpdate.Text = shelf.Description;
                }
                else
                {
                    txtMaterialLocationUpdate.Text = string.Empty;
                    txtShelfQuantityUpdate.Text = string.Empty;
                    richLocationDescriptionUpdate.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                shelf.Location = txtMaterialLocationUpdate.Text;
                shelf.Quantity = Convert.ToInt32(txtShelfQuantityUpdate.Text);
                shelf.Description = richLocationDescriptionUpdate.Text;
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

        private void btnSearchDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchMaterialLocationDelete.Text != string.Empty)
                {
                    storedShelf = shelfBLL.GetAll();

                    foreach (var specifiedShelf in storedShelf)
                    {
                        if (specifiedShelf.Location == txtSearchMaterialLocationDelete.Text)
                        {
                            shelf = specifiedShelf;
                        }
                    }

                    txtMaterialLocationDelete.Text = shelf.Location;
                    txtShelfQuantityDelete.Text = shelf.Quantity.ToString();
                }
                else
                {
                    txtMaterialLocationDelete.Text = "---";
                    txtShelfQuantityDelete.Text = "---";

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int GetShelfId(string location)
        {
            foreach (var item in storedShelf)
            {
                if (item.Location == location)
                {
                    return item.ShelfId;
                }
            }
            return -1;
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                shelfBLL = new ShelfBLL();

                int shelfId = GetShelfId(txtMaterialLocationDelete.Text);
                   
                if (shelfId >0 )
                {
                    int i = shelfBLL.Delete(shelfId);
                    if (i == 0)
                    {
                        MessageBox.Show("Shelf deleted successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (i == 1)
                    {
                        MessageBox.Show("Shelf is not deleted, there are still books on this shelf, please kindly change their location", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Shelf is not deleted, Please contact your administrator", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }
            shelfBLL.Delete(shelf.ShelfId);
            //little code because Delete Operation is not yet implemented in DAL for Shelf!
        }

        private void LblShelfQuantityDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

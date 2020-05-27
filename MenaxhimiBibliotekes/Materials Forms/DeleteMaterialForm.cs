using MenaxhimiBibliotekes.BLL;
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
    public partial class DeleteMaterialForm : Form
    {
        MaterialBLL materialbll;
        Material material;
        public DeleteMaterialForm()
        {
            InitializeComponent();
        }

        private void BtnSearchMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                materialbll = new MaterialBLL();
                material = new Material();

                int n;
                bool isNumeric = int.TryParse(txtMaterialID.Text, out n);

                if (isNumeric)
                {
                  material =  materialbll.Get(n);
                }

                if (material != null)
                {
                    txtTitle.Text = material.Title;
                    txtGenre.Text = material._Genre._Genre;
                    txtLanguage.Text = material._Language._Language;
                    txtAuthor.Text = material._Author.AuthorName;
                    if (material.ISBN.Length > 1)
                    {
                        txtISBN.Text = material.ISBN;
                    }
                    txtMaterialType.Text = material._MaterialType._MaterialType;

                    txtPages.Text = material.NumberOfPages.ToString();

                    if (true)
                    {
                        txtPublishDate.Text = material.PublishYear.Year.ToString();
                    }


                    if (material._PublishHouse._PublishHouse.Length > 1)
                    {
                        txtPublishHouse.Text = material._PublishHouse._PublishHouse;
                    }


                    txtQuantity.Text = material.Quantity.ToString();

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (materialbll.Delete(int.Parse(txtMaterialID.Text)) == 0)
                {
                    MessageBox.Show("Deleted successfuly");
                }
                else
                {
                    throw new Exception();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("This material is not deleted please contact your administrator");
            }
        }
    }
}

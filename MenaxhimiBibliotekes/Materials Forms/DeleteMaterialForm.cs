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
        //Global Variables
        Material material;
        MaterialBLL materialBLL;

        public DeleteMaterialForm()
        {
            InitializeComponent();
        }

        private void btnSearchMaterial_Click(object sender, EventArgs e)
        {
            if (txtMaterialID.Text != string.Empty)
            {
                //material = materialBLL.Get(Convert.ToInt32(txtMaterialID.Text));

                //txtTitle.Text = material.Title;
                //txtAuthor.Text = material._Author.AuthorName;
                //txtGenre.Text = material._Genre._Genre;
                //txtLanguage.Text = material._Language._Language;
                //txtISBN.Text = material.ISBN;
                //txtMaterialType.Text = material._MaterialType._MaterialType;
                //txtPublishHouse.Text = material._PublishHouse._PublishHouse;
                //txtPublishDate.Text = material.PublishYear.ToString();
                //txtPublishPlace.Text = material.PublishPlace;
                //txtQuantity.Text = material.Quantity.ToString();
                //txtPages.Text = material.NumberOfPages.ToString();
            }
            else
            {
                txtTitle.Text = "---";
                txtAuthor.Text = "---";
                txtGenre.Text = "---";
                txtLanguage.Text = "---";
                txtISBN.Text = "---";
                txtMaterialType.Text = "---";
                txtPublishHouse.Text = "---";
                txtPublishDate.Text = "---";
                txtPublishPlace.Text = "---";
                txtQuantity.Text = "---";
                txtPages.Text = "---";
            }
        }
    }
}

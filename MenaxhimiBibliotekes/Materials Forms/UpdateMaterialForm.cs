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
    public partial class UpdateMaterialForm : Form
    {
        // Global Variables
        Material material;
        MaterialBLL materialBLL;
        List<Material> materialList;

        GenreBLL genreBLL;
        List<Genre> genreList;


        public UpdateMaterialForm()
        {
            InitializeComponent();
            material = new Material();
            materialBLL = new MaterialBLL();
            materialList = new List<Material>();

            comboGenre.Items.Clear();
            genreBLL = new GenreBLL();
            genreList = genreBLL.GetAll();
            comboGenre.DataSource = genreList;
            comboGenre.DisplayMember = "_Genre";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            material = materialBLL.Get(Convert.ToInt32(txtMaterialID.Text));

            //materialList = materialBLL.GetAll();


        }

        private void txtMaterialID_TextChanged(object sender, EventArgs e)
        {
            material = materialBLL.Get(Convert.ToInt32(txtMaterialID.Text));

            txtTitle.Text = material.Title;
            txtAuthor.Text = material._Author.AuthorName;
        }
    }
}

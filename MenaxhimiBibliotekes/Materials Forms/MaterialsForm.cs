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
    public partial class MaterialsForm : Form
    {

        ReservationsForm reservationForm = new ReservationsForm();
        BorrowingsForm borrowingsForm = new BorrowingsForm();
        ReturningsForm returningsForm = new ReturningsForm();
        BorrowBLL bbll = new BorrowBLL();
        ReservationBLL res;
        Reservation reservationBO;
        MaterialBLL materialBLL = new MaterialBLL();

        public MaterialsForm()
        {
            InitializeComponent();
            gridView.OptionsBehavior.AutoPopulateColumns = false;
            gridMaterials.DataSource = materialBLL.GetAll();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            AddNewMaterial add = new AddNewMaterial();
            add.ShowDialog();
        }

        private void btnUpdateMaterial_Click(object sender, EventArgs e)
        {
            UpdateMaterialForm update = new UpdateMaterialForm();
            update.ShowDialog();
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            DeleteMaterialForm delete = new DeleteMaterialForm();
            delete.ShowDialog();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            if (reservationForm.IsDisposed)
            {
                reservationForm = new ReservationsForm();
            }

            reservationForm.ShowDialog();
        }

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
            if (borrowingsForm.IsDisposed)
            {
                borrowingsForm = new BorrowingsForm();
            }

            borrowingsForm.ShowDialog();
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            if (returningsForm.IsDisposed)
            {
                returningsForm = new ReturningsForm();
            }

            returningsForm.ShowDialog();
        }

        private void btnSearchMaterial_Click(object sender, EventArgs e)
        {
            gridMaterials.DataSource = null;

            if (txtSearchMaterial.Text == string.Empty)
            {
                gridMaterials.DataSource = materialBLL.GetAll();
            }
            else
            {
                gridMaterials.DataSource = materialBLL.GetAll().Where(x => x.Title.Contains(txtSearchMaterial.Text)  );
            }    
        }

        private void TableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridSplitContainer1Grid_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

            //x => x._subscriber.SubscriberId == 2 ||
            int m;
            bool isNumeric = int.TryParse(txtBorrowings.Text, out m);

            if (comboChoseGrid.SelectedItem == "Borrowings")
            {




                if (isNumeric)
                {
                    gridBorrowings.DataSource = bbll.GetAll().Where(x => x.SubscriberId == m ||
                    x.materialId == m || x.BorrowId == m);
                }
                else
                {
                    gridBorrowings.DataSource = bbll.GetAll().Where(x => $"{x._subscriber.Name} {x._subscriber.LastName}" == txtBorrowings.Text ||
                      x._material.Title == txtBorrowings.Text || x._material._Author.AuthorName == txtBorrowings.Text || x._shelf.Location == txtBorrowings.Text);
                }
            }

            else
            {
                reservationBO = new Reservation();
                res = new ReservationBLL();

                if (isNumeric)
                {
                    gridBorrowings.MainView = gridView3;
                    gridBorrowings.DataSource = res.GetAll().Where(x => x.SubscriberId == m ||
                    x.MaterialId == m || x.MaterialId == m);
                }
                else
                {
                    gridBorrowings.MainView = gridView1;
                    if (txtBorrowings.Text == string.Empty)
                    {
                        gridBorrowings.DataSource = res.GetAll();
                    }
                    else
                    {
                        gridBorrowings.DataSource = res.GetAll().Where(x => $"{x._subscriber.Name} {x._subscriber.LastName}" == txtBorrowings.Text||
                        x._material.Title == txtBorrowings.Text || x._material._Author.AuthorName == txtBorrowings.Text );
                    }
                }
            }
            

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

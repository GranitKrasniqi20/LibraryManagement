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

        public MaterialsForm()
        {
            InitializeComponent();
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
    }
}

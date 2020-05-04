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
    }
}

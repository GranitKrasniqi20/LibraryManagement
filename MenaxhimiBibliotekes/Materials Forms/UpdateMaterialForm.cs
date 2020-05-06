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
        MaterialTypeBLL mtbll;
        List<MaterialType> allMt;
        public UpdateMaterialForm()
        {
            InitializeComponent();
             mtbll = new MaterialTypeBLL();



            mtbll = new MaterialTypeBLL();
            MaterialType mt = new MaterialType();
            allMt = mtbll.GetAll();
            mt = allMt[0];
            allMt[0] = new MaterialType() { MaterialTypeId = 0, _MaterialType = "Other" };
            allMt.Add(mt);


            comboMaterialType.DataSource = allMt;
            comboMaterialType.DisplayMember = "_MaterialType";




        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void ComboMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

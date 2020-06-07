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
    public partial class MaterialTypeForm : Form
    {

        MaterialTypeBLL mtbll;
        MaterialType mt;
        MaterialTypeValidation mtValidate;
        List<MaterialType> storedMT;
        bool booleanVariable;
        decimal delayFeeDefault = 2.00M;

        public MaterialTypeForm()
        {
            InitializeComponent();
            mtbll = new MaterialTypeBLL();
            mt = new MaterialType();
            mtValidate = new MaterialTypeValidation();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtValidate.ValidateMaterialType(txtMaterialTypeCreate.Text.Trim()))
                {
                    mt._MaterialType = txtMaterialTypeCreate.Text.Trim();
                    mt.MaterialTypeDelayFee = delayFeeDefault;
                    mt.InsBy = FormLoggedUser.Id;


                    int error = mtbll.Add(mt);
                    if (error == 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Material Type name  should be uniqe, please if this material type is deactivated update it");
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("MaterialType is not valid");
            }
            catch (Exception)
            {
                MessageBox.Show("MaterialType is not inserted please contact your administrator");
            }
        }

        private void comboIsActiveUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboIsActiveUpdate.SelectedItem == "Active")
            {
                booleanVariable = true;
            }
            else
            {
                booleanVariable = false;
            }
        }

        private void btnSearchUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                storedMT = new List<MaterialType>();
                if (txtSearchMaterialTypeUpdate.Text != string.Empty)
                {
                    storedMT = mtbll.GetAll();

                    foreach (var types in storedMT)
                    {
                        if (types._MaterialType == txtSearchMaterialTypeUpdate.Text)
                        {
                            mt = types;
                        }
                    }

                    txtMaterialTypeIDUpdate.Text = mt.MaterialTypeId.ToString();
                    txtMaterialTypeUpdate.Text = mt._MaterialType;
                }
                else
                {
                    txtMaterialTypeIDUpdate.Text = "---";
                    txtMaterialTypeUpdate.Text = string.Empty;
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
                if (mtValidate.ValidateMaterialType(txtSearchMaterialTypeUpdate.Text.Trim()))
                {
                    mt._MaterialType = txtMaterialTypeUpdate.Text;
                    mt.UpdBy = FormLoggedUser.Id;
                    mt.isActive = booleanVariable;

                    int error = mtbll.Update(mt);
                    if (error == 0)
                    {
                        MessageBox.Show("This Material Type is updated succesfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Material Type could not be Updated!");
                    }
                }
                else
                {
                    throw new FormatException();
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
                if (txtSearchMaterialTypeDelete.Text != string.Empty)
                {
                    storedMT = mtbll.GetAll();

                    foreach (var types in storedMT)
                    {
                        if (types._MaterialType == txtSearchMaterialTypeDelete.Text)
                        {
                            mt = types;
                        }
                    }

                    txtMaterialTypeIDDelete.Text = mt.MaterialTypeId.ToString();
                    txtMaterialTypeDelete.Text = mt._MaterialType;
                }
                else
                {
                    txtMaterialTypeIDDelete.Text = "---";
                    txtMaterialTypeDelete.Text = "---";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaterialTypeIDDelete.Text != string.Empty)
                {
                    if (mtbll.Delete(int.Parse(txtMaterialTypeIDDelete.Text))==0)
                    {
                        MessageBox.Show("Material deleted succesfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Material Type is not deleted please contact your administrator", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

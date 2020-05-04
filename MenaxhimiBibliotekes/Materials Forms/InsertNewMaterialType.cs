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
    public partial class InsertNewMaterialType : Form
    {
        MaterialTypeBLL mtbll;
        MaterialType mt;
        MaterialTypeValidation mtValidate;

        public InsertNewMaterialType()
        {
            InitializeComponent();
            mtbll = new MaterialTypeBLL();
            mt = new MaterialType();
            mtValidate = new MaterialTypeValidation();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtValidate.ValidateMaterialType(txtInsert.Text.Trim()))
                {
                    mt._MaterialType = txtInsert.Text.Trim();
                    mt.InsBy = 80;//FormLoggedUser.Id;
                    
                    if (mtbll.Add(mt))
                    {
                        this.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }

                }

                

                else
                {
                    throw new FormatException();
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Language is not valid");
            }
            catch (Exception)
            {

                MessageBox.Show("Language not inserted please contact your administrator");
            }
        }
    }
}

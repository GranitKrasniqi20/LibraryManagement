﻿using MenaxhimiBibliotekes.BLL;
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

                    int error = mtbll.Add(mt);
                    if (error == 0)
                    {
                        this.Close();
                    }

                    else if (error == 1)
                    {
                        MessageBox.Show("MaterialType name  should be uniqe, please if this material type is deactivated update it");
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
    }
}

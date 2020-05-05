using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BLL.Validate;

namespace MenaxhimiBibliotekes.Materials_Forms
{
    public partial class InsertNewLanguage : Form
    {
        LanguageBLL langbll;
        Language lang;
        LanguageValidation langValidate;
        public InsertNewLanguage()
        {
            InitializeComponent();
            langbll = new LanguageBLL();
            lang = new Language();
            langValidate = new LanguageValidation();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                if(langValidate.validateLanguage(txtInsert.Text.Trim()))
                { 

                lang._Language = txtInsert.Text;
                    lang.InsBy = 80;//FormLoggedUser.Id;

                    int error = langbll.Add(lang);
                    if (error == 0)
                    {
                        this.Close();
                    }

                    else if (error == 1)
                    {
                        MessageBox.Show("Genre name  should be uniqe, please if this material type is deactivated update it");
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Genre is not valid");
            }
            catch (Exception)
            {
                MessageBox.Show("Genre is not inserted please contact your administrator");
            }


        }
    }
}

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
                   // langbll.Add(lang);
                    if (langbll.Add(lang))
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

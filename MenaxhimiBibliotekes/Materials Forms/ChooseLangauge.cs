using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.Materials_Forms
{
    public partial class ChooseLangauge : Form
    {
        public ChooseLangauge()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string language;
            
            if (rBAlbanish.Checked)
            {
                language = "sq";
            }

            else
            {
                language = "en-US";
            }

            List<Form> lastOpenedForm;
            lastOpenedForm = Application.OpenForms.Cast<Form>().ToList();
            foreach (Form item in lastOpenedForm)
            {



                if (item.Name == "mainForm")
                {
                    BLL.ChooseLanguage<mainForm>.ChangeLanguage(language, item);


                }
                else if (item.Name == "SettingsForm")
                {
                    BLL.ChooseLanguage<Settings_Forms.SettingsForm>.ChangeLanguage(language, item);
                }

                else if (item.Name == "ChooseLangauge")
                {
                    BLL.ChooseLanguage<ChooseLangauge>.ChangeLanguage(language, this);
                }

            }

        }
    }
}

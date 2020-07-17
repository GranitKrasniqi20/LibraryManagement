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
            
            if (rBAlbanish.Checked)
            {
                BLL.ChooseLanguage<ChooseLangauge>.ChangeLanguage("sq", this);
            }

            else
            {
                BLL.ChooseLanguage<ChooseLangauge>.ChangeLanguage("en-US", this);
            }
            this.Close();
            

        }
    }
}

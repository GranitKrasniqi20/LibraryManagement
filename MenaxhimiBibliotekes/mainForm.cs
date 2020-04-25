using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            panelSubmenu.Controls.Clear();
            panelSubmenu.Controls.Add(c);
        }

        private void ShowSubmenu()
        {
            lblNothingToDisplay.Hide();
            panelSubmenu.Show();
        }

        private void appLogo_Click(object sender, EventArgs e)
        {
            panelSubmenu.Hide();
            lblNothingToDisplay.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelSubmenu.Hide();
            lblNothingToDisplay.Show();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            ShowSubmenu();

            Submenus_User_Controls.ucMembers ucm = new Submenus_User_Controls.ucMembers();
            AddControlsToPanel(ucm);
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            ShowSubmenu();

            Submenus_User_Controls.ucMaterials ucmat = new Submenus_User_Controls.ucMaterials();
            AddControlsToPanel(ucmat);
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            panelSubmenu.Hide();
            lblNothingToDisplay.Hide();

            Login_Forms.loginForm loginform = new Login_Forms.loginForm();
            loginform.MdiParent = this;
            loginform.Show();
        }
    }
}

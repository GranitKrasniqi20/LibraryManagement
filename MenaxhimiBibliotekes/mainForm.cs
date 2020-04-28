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
            panelSubmenu.Hide();
            lblNothingToDisplay.Show();

            
        }

        Members_Forms.MembersForm membersform = new Members_Forms.MembersForm();
        Materials_Forms.MaterialsForm materialsform = new Materials_Forms.MaterialsForm();

        //Customized Design Methods
        private void AddControlsToPanel(Control c)
        {
            panelSubmenu.Controls.Clear();
            panelSubmenu.Controls.Add(c);
        }

        private void CloseAllWindows()
        {
            membersform.Hide();
            materialsform.Hide();
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
            CloseAllWindows();

            membersform.MdiParent = this;
            membersform.Show();
            membersform.WindowState = FormWindowState.Maximized;
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            CloseAllWindows();

            materialsform.MdiParent = this;
            materialsform.Show();
            materialsform.WindowState = FormWindowState.Maximized;
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

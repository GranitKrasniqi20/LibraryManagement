using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiBibliotekes.BO;

namespace MenaxhimiBibliotekes
{
    public partial class mainForm : Form
    {

        /// <summary>
        /// Global Variables & Instances
        /// </summary>
        Members_Forms.MembersForm membersform = new Members_Forms.MembersForm();
        Materials_Forms.MaterialsForm materialsform = new Materials_Forms.MaterialsForm();
        Settings_Forms.SettingsForm settingsform = new Settings_Forms.SettingsForm();



        /// <summary>
        /// Customized Form Design Methods
        /// </summary>

        private void CloseAllWindows()
        {
            membersform.Hide();
            materialsform.Hide();
            settingsform.Hide();
        }



        /// <summary>
        /// Constructor
        /// </summary>
        public mainForm()
        {
            InitializeComponent();
        }


        private void appLogo_Click(object sender, EventArgs e)
        {
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
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

            Login_Forms.loginForm loginform = new Login_Forms.loginForm();

            loginform.ShowDialog();

            
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            CloseAllWindows();

            settingsform.MdiParent = this;
            settingsform.Show();

        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            btnLoggedUser.Text = $"  {FormLoggedUser.Name} {FormLoggedUser.LastName}";
        }

        private void btnLoggedUser_Click(object sender, EventArgs e)
        {
            Settings_Forms.MyProfileForm profile = new Settings_Forms.MyProfileForm();

            profile.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login_Forms.loginForm loginform = new Login_Forms.loginForm();

            loginform.ShowDialog();
        }
    }
}

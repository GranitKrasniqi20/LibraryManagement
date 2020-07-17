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
using MenaxhimiBibliotekes.Materials_Forms;

namespace MenaxhimiBibliotekes
{
    public partial class mainForm : Form
    {

        /// <summary>
        /// Global Variables & Instances
        /// </summary>
        Dashboard_Forms.DashboardForm dashboardform = new Dashboard_Forms.DashboardForm();
        Members_Forms.MembersForm membersform = new Members_Forms.MembersForm();
        Materials_Forms.MaterialsForm materialsform = new Materials_Forms.MaterialsForm();
        Settings_Forms.SettingsForm settingsform = new Settings_Forms.SettingsForm();
        Notifications_Forms.NotificationsForm notificationsform = new Notifications_Forms.NotificationsForm();



        /// <summary>
        /// Customized Form Design Methods
        /// </summary>

        private void CloseAllWindows()
        {
            dashboardform.Hide();
            membersform.Hide();
            materialsform.Hide();
            settingsform.Hide();
            notificationsform.Hide();
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
            dashboardform.Close();
            if (dashboardform.IsDisposed)
            {
                dashboardform = new Dashboard_Forms.DashboardForm();
            }

            CloseAllWindows();

            dashboardform.MdiParent = this;
            dashboardform.Show();
            dashboardform.WindowState = FormWindowState.Maximized;
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            membersform.Close();
            if (membersform.IsDisposed)
            {
                membersform = new Members_Forms.MembersForm();
            }

            CloseAllWindows();

            membersform.MdiParent = this;
            membersform.Show();
            membersform.WindowState = FormWindowState.Maximized;
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            materialsform.Close();
            if (materialsform.IsDisposed)
            {
                materialsform = new Materials_Forms.MaterialsForm();
            }

            CloseAllWindows();

            materialsform.MdiParent = this;
            materialsform.Show();
            materialsform.WindowState = FormWindowState.Maximized;
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            notificationsform.Close();
            if (notificationsform.IsDisposed)
            {
                notificationsform = new Notifications_Forms.NotificationsForm();
            }

            CloseAllWindows();

            notificationsform.MdiParent = this;
            notificationsform.Show();
            notificationsform.WindowState = FormWindowState.Maximized;
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            Login_Forms.loginForm loginform = new Login_Forms.loginForm();

            loginform.ShowDialog();
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            btnLoggedUser.Text = $"  {FormLoggedUser.Name} {FormLoggedUser.LastName}";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsform.Close();
            if (settingsform.IsDisposed)
            {
                settingsform = new Settings_Forms.SettingsForm();
            }

            CloseAllWindows();

            settingsform.MdiParent = this;
            settingsform.Show();

        }

        private void btnLoggedUser_Click(object sender, EventArgs e)
        {
            Settings_Forms.MyProfileForm profile = new Settings_Forms.MyProfileForm();

            profile.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }

            Login_Forms.loginForm loginform = new Login_Forms.loginForm();

            loginform.ShowDialog();
        }

        private void openMyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_Forms.MyProfileForm myProfile = new Settings_Forms.MyProfileForm();
            myProfile.ShowDialog();
        }

        private void editUserAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_Forms.ManageUserAccountsForm manageAccounts = new Settings_Forms.ManageUserAccountsForm();
            manageAccounts.ShowDialog();
        }

        private void createMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Members_Forms.AddMemberForm addMember = new Members_Forms.AddMemberForm();
            addMember.ShowDialog();
        }

        private void updateMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Members_Forms.UpdateMemberForm updateMember = new Members_Forms.UpdateMemberForm();
            updateMember.ShowDialog();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Members_Forms.DeleteMemberForm deleteMember = new Members_Forms.DeleteMemberForm();
            deleteMember.ShowDialog();
        }

        private void createMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials_Forms.AddNewMaterial addMaterial = new Materials_Forms.AddNewMaterial();
            addMaterial.ShowDialog();
        }

        private void updateMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials_Forms.UpdateMaterialForm updateMaterial = new Materials_Forms.UpdateMaterialForm();
            updateMaterial.ShowDialog();
        }

        private void deleteMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials_Forms.DeleteMaterialForm deleteMaterial = new Materials_Forms.DeleteMaterialForm();
            deleteMaterial.ShowDialog();
        }

        private void alterMaterialTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials_Forms.MaterialTypeForm alterMaterialType = new Materials_Forms.MaterialTypeForm();
            alterMaterialType.ShowDialog();
        }

        private void alterMaterialLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials_Forms.MaterialLocation alterMaterialLocation = new Materials_Forms.MaterialLocation();
            alterMaterialLocation.ShowDialog();
        }

        private void alterGenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials_Forms.GenreForm alterGenres = new Materials_Forms.GenreForm();
            alterGenres.ShowDialog();
        }

        private void alterLanguagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials_Forms.LanguageForm alterLanguages = new Materials_Forms.LanguageForm();
            alterLanguages.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BorrowBLL borrBLL = new BorrowBLL();
            borrBLL.EmailBorrowsToReturn();
            
        }

        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProgressPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using MenaxhimiBibliotekes.Materials_Forms;

namespace MenaxhimiBibliotekes.Settings_Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            if (FormLoggedUser.Role.UserRoleId == 2)
            {
                MessageBox.Show("You don't have permison to manage users", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ManageUserAccountsForm manage_users = new ManageUserAccountsForm();
                manage_users.ShowDialog();
            }
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm profile = new MyProfileForm();
            profile.ShowDialog();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtRole.Text = FormLoggedUser.Role.UserRole;
        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ChooseLangauge lang = new ChooseLangauge();
            lang.ShowDialog();
        }
    }
}

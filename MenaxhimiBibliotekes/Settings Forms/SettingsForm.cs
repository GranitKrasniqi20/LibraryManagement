using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ManageUserAccountsForm manage_users = new ManageUserAccountsForm();
            manage_users.ShowDialog();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm profile = new MyProfileForm();
            profile.ShowDialog();
        }
    }
}

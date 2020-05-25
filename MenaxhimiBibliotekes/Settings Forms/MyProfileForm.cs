using MenaxhimiBibliotekes.BO;
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
    public partial class MyProfileForm : Form
    {
        public MyProfileForm()
        {
            InitializeComponent();
        }


        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            txtName.Text = FormLoggedUser.Name + " " + FormLoggedUser.LastName;
            txtID.Text = FormLoggedUser.Id.ToString();
            txtEmail.Text = FormLoggedUser.Email;
            txtUsername.Text = FormLoggedUser.Username;
            txtPassword.Text = FormLoggedUser.Password;
            txtRole.Text = FormLoggedUser.Role.UserRole;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMyProfile edit = new EditMyProfile();
            edit.ShowDialog();
        }
    }
}

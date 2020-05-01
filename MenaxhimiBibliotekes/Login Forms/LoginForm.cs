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

namespace MenaxhimiBibliotekes.Login_Forms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsernameLogin.Text == "beispresheva" && txtPasswordLogin.Text == "luletebunari123")
                {
                    FormLoggedUser.Name = "Beis";
                    FormLoggedUser.LastName = "Presheva";
                    FormLoggedUser.Username = txtUsernameLogin.Text;
                    FormLoggedUser.Password = txtPasswordLogin.Text;
                    FormLoggedUser.Role = "Admin";
                }
                else
                {
                    MessageBox.Show("The Log In Information you typed is incorrect. \nPlease try again!", "Information Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

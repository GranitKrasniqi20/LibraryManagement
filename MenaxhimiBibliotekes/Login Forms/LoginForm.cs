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

namespace MenaxhimiBibliotekes.Login_Forms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            lblUsernameError.Hide();
            lblPasswordError.Hide();
        }
        //string pw = usbll.LogIn(usr.Username, usr.Password).Password;

        //    if (usbll.LogIn(usr.Username, usr.Password).Password == Sec.Hash("Endrittmava", "123123"))
        //    {
        //        Console.WriteLine("mir osht");
        //    }



        private void btnLogin_Click(object sender, EventArgs e)
        {


            try
            {

                UserBLL usrbll = new UserBLL();
                User usr = new User();

                string pw = Sec.Hash(txtUsernameLogin.Text, txtPasswordLogin.Text);




                usr = usrbll.LogIn(txtUsernameLogin.Text, pw);

                if (usr == null)
                {
                    throw new Exception();
                }

                else if (usr.Password == pw)
                {
                    FormLoggedUser.Id = usr.UserID;
                    FormLoggedUser.Name = usr.Name;
                    FormLoggedUser.LastName = usr.LastName;
                    FormLoggedUser.Username = txtUsernameLogin.Text;
                    FormLoggedUser.Password = txtPasswordLogin.Text;
                    FormLoggedUser.Role = usr._role;
                    


                    //MessageBox.Show($"You logged successfully, {FormLoggedUser.Name} {FormLoggedUser.LastName} ({FormLoggedUser.Username})!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    this.Hide();
                }

                else
                {
                    throw new Exception();
                }




            }
            catch (Exception)
            {
                MessageBox.Show("The Log In Information you typed is incorrect. \nPlease try again!", "Information Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

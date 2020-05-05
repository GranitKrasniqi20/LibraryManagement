using FluentValidation.Results;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BLL.Validate;
using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.Settings_Forms
{
    public partial class ManageUserAccountsForm : Form
    {
        string errors = "";
        List<Role> role;
        RoleBLL rolebll;
        User usr;
        UserBLL usrbll;
        public ManageUserAccountsForm()
        {
            InitializeComponent();
            rolebll = new RoleBLL();
            role = rolebll.GetAllRoles();
            usr = new User();
            usrbll = new UserBLL();

            comboRoleCreate.DataSource = role;
        }



        private void BtnCreate_Click(object sender, EventArgs e)
        {


            try
            {



                usr.Name = txtNameCreate.Text;
                usr.LastName = txtLastNameCreate.Text;
                usr.Email = txtEmailCreate.Text;
                usr.Username = txtUsernameCreate.Text;
                usr.InsBy = FormLoggedUser.Id;
                usr.Password = txtPasswordCreate.Text;
                //usr._role = getRole();
                usr.RoleID = usr._role.UserRoleId;

                UsersValidation usrval = new UsersValidation();
                ValidationResult vres = usrval.Validate(usr);

                if (vres.IsValid == false)
                {

                    foreach (ValidationFailure item in vres.Errors)
                    {
                        errors += $"{item.ErrorMessage} + \n";
                    }
                    MessageBox.Show(errors);
                }

                int error = usrbll.Add(usr);

                if (error == 0)
                {
                    this.Close();
                }

                else if (error == 1)
                {
                    MessageBox.Show("User username  should be uniqe, please if this material type is deactivated update it");
                }
                else
                {
                    throw new Exception();
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Genre is not valid");
            }





            catch (Exception)
            {
                MessageBox.Show("Genre is not inserted please contact your administrator");
            }




        }
        public Role getRole()
        {
            return comboRoleCreate.SelectedItem as Role;
        }

    }




}



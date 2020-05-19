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
        List<User> users;
        UsersValidation usrval;



        public ManageUserAccountsForm()
        {
            InitializeComponent();
            usrval = new UsersValidation();
            rolebll = new RoleBLL();
            role = rolebll.GetAllRoles();

            usr = new User();
            usrbll = new UserBLL();
            users = new List<User>();
           
            comboRoleCreate.DataSource = role;
            comboRoleCreate.DisplayMember = "UserRole";


        }



        private void BtnCreate_Click(object sender, EventArgs e)
        {


            try
            {

                if (FormLoggedUser.Role.UserRoleId == 1)
                {
                    MessageBox.Show("You don't have permision to create users", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    usr.Name = txtNameCreate.Text;
                    usr.LastName = txtLastNameCreate.Text;
                    usr.Email = txtEmailCreate.Text;
                    usr.Username = txtUsernameCreate.Text;
                    usr.InsBy = FormLoggedUser.Id;
                    usr.Password = Sec.Hash(usr.Username, txtPasswordCreate.Text);
                    usr._role = getRoleCreate();
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
                        MessageBox.Show("This username alreay exists, please if this user is deactivated you can update it");
                    }
                    else if (error == -1)
                    {
                        throw new Exception();
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("User is not valid");
            }


            catch (Exception)
            {
                MessageBox.Show("User is not inserted please contact your administrator");
            }




        }
        public Role getRoleCreate()
        {
            return comboRoleCreate.SelectedItem as Role;
        }

        public Role getRoleUpdate()
        {
            return comboRoleEdit.SelectedItem as Role;
        }

        private void BtnUpdateAccount_Click(object sender, EventArgs e)
        {


            if (FormLoggedUser.Role.UserRoleId == 1)
            {
                MessageBox.Show("You don't have permision to update users", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usr = new User();

                usr.Name = txtNameEdit.Text;
                usr.LastName = txtLastNameEdit.Text;
                usr.Email = txtEmailEdit.Text;
                usr.Username = txtUsernameEdit.Text;

                if ("Yes" == txtIsActiveEdit.Text || "yes" == txtIsActiveEdit.Text)
                {

                    usr.IsActive = true;
                }
                else
                {
                    usr.IsActive = false;
                }

                usr.InsBy = FormLoggedUser.Id;
                usr._role = getRoleUpdate();
                usr.RoleID = usr._role.UserRoleId;


                usrval.validateUpdateUser();
                ValidationResult vres = usrval.Validate(usr);




                if (vres.IsValid == false)
                {

                    errors = "";
                    foreach (ValidationFailure item in vres.Errors)
                    {
                        errors += $"       {item.ErrorMessage}        \n \n";
                    }

                    MessageBox.Show(errors, "ERROR WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    usrbll = new UserBLL();
                    if (usrbll.Update(usr) == 0)
                    {
                        MessageBox.Show("User updated succesfuly", "USER UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }


        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (FormLoggedUser.Role.UserRoleId == 1)
                {
                    MessageBox.Show("You don't have permision to delete users", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    usr = new User();
                    usrbll = new UserBLL();

                    usr = usrbll.GetByUsername(txtUsernameEdit.Text);


                    if (usr == null)
                    {
                        throw new NullReferenceException();
                    }



                    Role ro = role[0];
                    role[0] = usr._role;

                    role.Add(ro);



                    comboRoleEdit.DataSource = role;
                    comboRoleEdit.DisplayMember = "UserRole";



                    txtNameEdit.Text = usr.Name;
                    txtLastNameEdit.Text = usr.LastName;
                    txtEmailEdit.Text = usr.Email;


                    if (usr.IsActive)
                    {
                        txtIsActiveEdit.Text = "Yes";

                    }
                    else
                    {
                        txtIsActiveEdit.Text = "No";
                    }
                    usr._role = usr._role;
                    usr.RoleID = usr._role.UserRoleId;

                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("User not found !");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnSearchToDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (FormLoggedUser.Role.UserRoleId == 1)
                {
                    MessageBox.Show("You don't have permision to delete users", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    usr = new User();


                    usr = usrbll.GetByUsername(txtDelete.Text);

                    if (usr == null)
                    {
                        throw new NullReferenceException();
                    }





                    txtDeleteUserId.Text = usr.UserID.ToString();
                    txtNameDelete.Text = usr.Name;
                    txtLastNameDelete.Text = usr.LastName;
                    txtEmailDelete.Text = usr.Email;
                    txtIsActiveDelete.Text = usr.Username;


                    if (usr.IsActive)
                    {
                        txtIsActiveDelete.Text = "Yes";
                    }
                    else
                    {
                        txtIsActiveDelete.Text = "No";
                    }
                    txtRoleDelete.Text = usr._role.UserRole;
                }
               


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("User not found !");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (FormLoggedUser.Role.UserRoleId == 1)
                {
                    MessageBox.Show("You don't have permision to delete users", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (usrbll.Delete(int.Parse(txtDeleteUserId.Text)) == 0)
                    {
                        MessageBox.Show("User deleted succesfuly", "USER DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnEditChangePassword_Click(object sender, EventArgs e)
        {
            try
            {

                if (FormLoggedUser.Role.UserRoleId == 1)
                {
                    MessageBox.Show("You don't have permision to change passwords", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {


                    usr = new User();
                    usrbll = new UserBLL();
                    usr = usrbll.GetByUsername(txtUserSearchChangePassword.Text);

                    if (usr == null)
                    {
                        throw new NullReferenceException();
                    }


                    txtUsernameChangePassword.Text = usr.Username;

                }

            }

             catch (NullReferenceException)
            {
                MessageBox.Show("User not found !");
            }
            catch (Exception)
            {
                MessageBox.Show("User is not deleted please contact your administrator  !", "WARNING",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormLoggedUser.Role.UserRoleId == 1)
                {
                    MessageBox.Show("You don't have permision to change passwords", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    usrbll.ChangePassword(usr.UserID, Sec.Hash(txtUsernameChangePassword.Text, txtPasswordChangePassword.Text), FormLoggedUser.Id);
                    this.Close(); 
                }
            }

            catch (Exception)
            {

                throw;
            }
            
        }

        private void ComboRoleEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }




}



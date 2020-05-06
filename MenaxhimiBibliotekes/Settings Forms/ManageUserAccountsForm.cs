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
        UsersValidation usrval = new UsersValidation();



        public ManageUserAccountsForm()
        {
            InitializeComponent();
            rolebll = new RoleBLL();
            role = rolebll.GetAllRoles();

            usr = new User();
            usrbll = new UserBLL();
            users = new List<User>();
           
            comboRoleCreate.DataSource = role;
            comboRoleCreate.DisplayMember = "UserRole";







            users = usrbll.GetAll();

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
            usr = new User();


            usr.Name = txtNameEdit.Text;
            usr.LastName = txtLastNameEdit.Text;
            usr.Email = txtEmailEdit.Text;
            usr.Username = txtUsernameEdit.Text;

            if ("Yes" == txtIsActiveEdit.Text|| "yes" == txtIsActiveEdit.Text)
            {

                usr.IsActive = true;
            }
            else
            {
                usr.IsActive = false ;
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
                usrbll.Update(usr);
            }


        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {






                usr = new User();

                foreach (var item in users)
                    {
                        if (item.Username == txtUsernameEdit.Text)
                        {
                        usr = item;
                        }
                    }

                Role ro = role[0];
                role[0] = usr._role;

                role.Add(ro);



                comboRoleEdit.DataSource = role;
                comboRoleEdit.DisplayMember = "UserRole";




                txtNameEdit.Text= usr.Name ;
                txtLastNameEdit.Text= usr.LastName;
                txtEmailEdit.Text = usr.Email;


                if (usr.IsActive)
                {
                    txtIsActiveEdit.Text ="Yes";

                }
                else
                {
                    txtIsActiveEdit.Text = "No";
                }
                usr._role = usr._role;
                usr.RoleID = usr._role.UserRoleId;


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
                usr = new User();

                foreach (var item in users)
                {
                    if (item.Username == txtDelete.Text)
                    {
                        usr = item;
                    }
                }




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
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            usr.IsActive = false;
            usrbll.Delete(usr.UserID);
        }

        private void BtnEditChangePassword_Click(object sender, EventArgs e)
        {

            usr = new User();

            foreach (var item in users)
            {
                if (item.Username == txtUserSearchChangePassword.Text)
                {
                    usr = item;
                }
            }


            txtUsernameChangePassword.Text = usr.Username;



        }

        private void BtnUpdatePassword_Click(object sender, EventArgs e)
        {
            usrbll.ChangePassword( usr.UserID,Sec.Hash(txtUsernameChangePassword.Text, txtPasswordChangePassword.Text),FormLoggedUser.Id);
            this.Close();
            
        }

        private void ComboRoleEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }




}



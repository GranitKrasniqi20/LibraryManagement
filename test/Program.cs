using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BLL.Validate;
using FluentValidation.Results;
using System.Windows.Forms;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            RoleBLL rolebll;
            List<Role> role;
            rolebll = new RoleBLL();

            role = rolebll.GetAllRoles();


            //comboRoleCreate.DataSource = role;


            string errors = "";



            User usr = new User();

            usr.Name = "a";
            usr.LastName = "a";
            usr.Email = "a";
            usr.Username = "a";
            usr.InsBy = FormLoggedUser.Id;
            usr.Password = "a";
            //usr._role = getRole();
            //usr.RoleID = usr._role.UserRoleId;

            UsersValidation usrval = new UsersValidation();
            usrval.validateUser();
            ValidationResult vres = usrval.Validate(usr);

            if (vres.IsValid == false)
            {

                foreach (ValidationFailure item in vres.Errors)
                {
                    errors += $"       {item.ErrorMessage}        \n \n";
                }

                MessageBox.Show(errors,"ERROR WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        //public Role getRole()
        //{
        //    return comboRoleCreate.SelectedItem as Role;
        //}

    }



}

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
using MenaxhimiBibliotekes.DAL;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            //SubscriberBLL sb = new SubscriberBLL();
          //  sb.GetExpiredSubscribersEmail();


            //EmailService em = new EmailService();


            //em.SendMails("beis.presheva@riinvest.net", "send from c# Endrit Tmava", "Funksionoi dergimi i email nga Library Management");
            //em.SendMails("granit.krasniqi1@riinvest.net", "send from c# Endrit Tmava", "Funksionoi dergimi i email nga Library Management");
            //    RoleBLL rolebll;
            //    List<Role> role;
            //    rolebll = new RoleBLL();

            //    role = rolebll.GetAllRoles();


            //    //comboRoleCreate.DataSource = role;


            //    string errors = "";



            //    User usr = new User();

            //    usr.Name = "a";
            //    usr.LastName = "a";
            //    usr.Email = "a";
            //    usr.Username = "a";
            //    usr.InsBy = FormLoggedUser.Id;
            //    usr.Password = "a";
            //    //usr._role = getRole();
            //    //usr.RoleID = usr._role.UserRoleId;

            //    UsersValidation usrval = new UsersValidation();
            //    usrval.validateCreateUser();
            //    ValidationResult vres = usrval.Validate(usr);

            //    if (vres.IsValid == false)
            //    {

            //        foreach (ValidationFailure item in vres.Errors)
            //        {
            //            errors += $"       {item.ErrorMessage}        \n \n";
            //        }

            //        MessageBox.Show(errors,"ERROR WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    }
            //}

            //public Role getRole()
            //{
            //    return comboRoleCreate.SelectedItem as Role;
            //}\


            //Material mat = new Material();
            //MaterialBLL mbll = new MaterialBLL();
            //mat.MaterialId = 1020;
            //mat.Title = "tryagain";
            //mat._Genre.GenreId = 1;
            //mat._PublishHouse._PublishHouse = "Shpijajem";
            //mat.PublishPlace = "FFK";
            //mat._MaterialType.MaterialTypeId = 1;
            //mat.AvailableCoppies = 4;
            //mat.Quantity = 4;
            //mat._Language.LanguageId = 1;
            //mat.LanguageId = 1;
            //mat.UpdBy = 80;
            //mat._Author.AuthorName = "Endrittmavahe";
            //Console.WriteLine(mbll.Update(mat).ToString());



            BorrowBLL borrow = new BorrowBLL();


            BorrowReturn br = new BorrowReturn();
            br.BorrowReturnId = 3;
            br.BorrowId = 2;
            br.ReturnDate = DateTime.Now;
            br.Comment = "asdenaaa";
            br.UpdBy = 80;
            BorrowReturnBLL brb = new BorrowReturnBLL();
            brb.Update(br);

            //foreach (var item in borrow.GetAll())
            //{
            //    Console.WriteLine($"{item.SubscriberId}, {item.materialId}, {item.DeadLine}");
            //}



        }


    }



}

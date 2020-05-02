using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            User usr = new User();
            //usr.Name = "Endrit";
            //usr.LastName = "Tmava";
            //usr.RoleID = 1;
            //usr.IsActive = true;
            //usr.Email = "Endrit.tmavaa@gmail.com";
            usr.Username = "Endrittmava";
            usr.Password = Sec.Hash(usr.Username, "123123");
            //usr.InsBy = 1;


            UserBLL usbll = new UserBLL();




            //usr.Password = Sec.Hash( usr.Password, usr.Username);
            //if (usbll.Update(usr))
            //{

            //    Console.WriteLine("true2");
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //if (usbll.Delete(usr.UserID))
            //{

            //    Console.WriteLine("true3");
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            //if (usbll.Add(usr))
            //{
            //    Console.WriteLine("true1");
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}



            string pw = usbll.LogIn(usr.Username, usr.Password).Password;

            if (usbll.LogIn(usr.Username, usr.Password).Password == Sec.Hash("Endrittmava", "123123"))
            {
                Console.WriteLine("mir osht");
            }

            Console.WriteLine(Sec.Hash("Endrittmava", "123123") + "                    " + pw);




        }
    }
}

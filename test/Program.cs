using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BLL;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BLL.Validate;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            //User usr = new User();
            //usr.Name = "Endrit";
            //usr.LastName = "Tmava";
            //usr.RoleID = 1;
            //usr.IsActive = true;
            //usr.Email = "Endrit.tmavaa@gmail.com";
            //usr.Username = "Endrittmava";
            //usr.Password = Sec.Hash(usr.Username, "123123");
            //usr.InsBy = 1;


            //UserBLL usbll = new UserBLL();




            //usr.Password = Sec.Hash(usr.Password, usr.Username);
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



            //string pw = usbll.LogIn(usr.Username, usr.Password).Password;

            //if (usbll.LogIn(usr.Username, usr.Password).Password == Sec.Hash("Endrittmava", "123123"))
            //{
            //    Console.WriteLine("mir osht");
            //}

            //Console.WriteLine(Sec.Hash("Endrittmava", "123123") + "                    " + pw);


            //MaterialType mt = new MaterialType();
            //mt._MaterialType = "Libra";
            //mt.InsBy = 80;
            //ICrud < MaterialType >  refs= new MaterialTypeBLL();

            //if (refs.Add(mt))
            //{
            //    Console.WriteLine(true);
            //}

            //Genre ge = new Genre();
            //ge._Genre = "Fantashkenc";
            //ge.InsBy = 80;
            //ICrud<Genre> refs1 = new GenreBLL();
            //if (refs1.Add(ge))
            //{
            //    Console.WriteLine(true);
            //}

            //ICrud<Shelf> refs = new ShelfBLL();
            //Shelf ra = new Shelf();
            //ra.Location = "veri";
            //ra.Quantity = 100;
            //ra.Description = "rafti veri";
            //ra.InsBy = 80;
            //ra.ShelfId = 1;



            //if (refs.Add(ra))
            //{
            //    Console.WriteLine("rafti u insertua me sukses");
            //}

            //Language lan = new Language();
            //lan.LanguageId = 5;
            //lan._Language = "English10";
            //lan.UpdBy = 80;
            //ICrud<Language> refs2 = new LanguageBLL();

            //if (refs2.Delete(lan.LanguageId))
            //{
            //    Console.WriteLine(true);
            //}

            //foreach (var item in refs2.GetAll())
            //{
            //    Console.WriteLine(item._Language +" \n" + " \n" + " \n");
            //}




            //Author au = new Author();
            //au.AuthorName = "Ismail Kadare";
            //au.InsBy = 80;


            //PublishHouse ph = new PublishHouse();
            //ph._PublishHouse = "Dukagjini";
            //ph.InsBy = 80;



            //Material ma = new Material();
            //ma.InsBy = 80;
            //ma.IsActive = true;
            //ma.ISBN = "123123";
            //ma.NumberOfPages = 123;
            //ma.PublishPlace = "kosove";
            //ma.PublishYear = DateTime.Now;
            //ma.Quantity = 3;
            //ma.Title = "Tom Sojer";

            //lan.LanguageId = 1;
            //ma._Language = lan;

            //ma._PublishHouse = ph;
            //ma._Author = au;

            //ge.GenreId = 1;
            //ma._Genre = ge;

            //mt.MaterialTypeId = 1;
            //ma._MaterialType= mt;
            //ma.InsBy = 80;
            //ma._Shelf = ra;
            //MaterialBLL mbll = new MaterialBLL();

            //if (mbll.Add(ma))
            //{
            //    Console.WriteLine("Success");
            //}


            //Genre ge = new Genre();
            //GenreBLL gebll = new GenreBLL();

            //ge.GenreId = 2;
            //ge._Genre = "diti";
            //ge.UpdBy = 80;


            //if (gebll.Update(ge))
            //{
            //    Console.WriteLine(true);
            //}


           Language lan = new Language();
            LanguageBLL lanbll = new LanguageBLL();

            lan._Language = "helloworld";
            lan.InsBy = 80;

            lanbll.Add(lan);
            //foreach (var item in lanbll.GetAll())
            //{
            //    Console.WriteLine(item._MaterialType + "\n");
            //}


        }
    }
}

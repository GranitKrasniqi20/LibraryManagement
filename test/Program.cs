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


            Shelf mtbll = new Shelf();
            ShelfBLL ma = new ShelfBLL();



            foreach (var item in ma.GetAll())
            {
                Console.WriteLine(item.Location  + "\n");
            }


        }
    }
}

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


            User mtbll = new User();
            UserBLL ma = new UserBLL();



            mtbll.UserID = 1085;

            mtbll.Username = "dityfdf";
            mtbll.Password = "asdadsss";
            mtbll.Name = "eas";
            mtbll.LastName = "asdasd";
            mtbll.Email = "asdas@sadas.com";
            mtbll.RoleID = 1;
            mtbll.UpdBy = 80;


            ma.Update(mtbll);
        }
    }
}

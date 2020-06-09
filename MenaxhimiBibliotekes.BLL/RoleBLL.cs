using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.DAL;

namespace MenaxhimiBibliotekes.BLL
{
    public class RoleBLL
    {
        RoleDAL roledal = new RoleDAL();


        public List<Role> GetAllRoles()
        {
            return roledal.GetAll();
        } 
    }
}

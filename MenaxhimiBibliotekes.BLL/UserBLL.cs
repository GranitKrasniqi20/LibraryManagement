using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.DAL;




namespace MenaxhimiBibliotekes.BLL
{
    class UserBLL : ICrud<User>
    {
        UserDAL usr = new UserDAL();
        public bool Add(User obj)
        {
           return usr.Add(obj);

        }

        public bool Delete(int Id)
        {
           return usr.Delete(Id);
         
        }

        public bool Delete(User obj)
        {
           return usr.Delete(obj);
        }

        public User Get(int Id)
        {
            return usr.Get(Id);
        }

        public User Get(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return usr.GetAll();
        }

        public bool Update(User obj)
        {
            return usr.Update(obj);
        }
    }
}

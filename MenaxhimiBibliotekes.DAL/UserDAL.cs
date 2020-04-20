using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
namespace MenaxhimiBibliotekes.DAL
{
    class UserDAL : ICrud<User>
    {
        public bool Add(User obj)
        {
            using ()
            {

            }
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public User Get(int Id)
        {
            throw new NotImplementedException();
        }

        public User Get(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class UserBLL : ICreate<User>, IUpdate<User>, IDelete, IRead<User>,IChangePassword
    {
        UserDAL usr = new UserDAL();

        public User LogIn(string username, string password)
        {
           return usr.LogIn(username, password);
        }
        public int Add(User obj)
        {
           return usr.Add(obj);

        }

        public int Delete(int Id)
        {
           return usr.Delete(Id);
         
        }



        public User Get(int Id)
        {
            return usr.Get(Id);
        }

        public User GetByUsername(string username)
        {
            return usr.GetUserByUsername(username);
        }

        public List<User> GetAll()
        {
            return usr.GetAll();
        }

        public int Update(User obj)
        {
            return usr.Update(obj);
        }

        public int ChangePassword(int UserId, string password,int UpdBy)
        {
          return  usr.ChangePassword( UserId,  password,  UpdBy);
        }
    }
}

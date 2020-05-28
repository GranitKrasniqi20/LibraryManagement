using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.DAL;

namespace MenaxhimiBibliotekes.BLL
{
   public class BorrowBLL : ICreate<Borrow>, IUpdate<Borrow>, IDelete, IRead<Borrow>
    {

        BorrowDAL bd = new BorrowDAL();

        public int Add(Borrow obj)
        {
            return bd.Add(obj);
        }

        public int Delete(int Id)
        {
            return bd.Delete(Id);
        }

        public Borrow Get(int Id)
        {

            return bd.Get(Id);
        }

        public List<Borrow> GetAll()
        {
            return bd.GetAll();
        }

        public int Update(Borrow obj)
        {
            return bd.Update(obj);
        }




    }
}

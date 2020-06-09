using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.DAL;

namespace MenaxhimiBibliotekes.BLL
{
   public class BorrowReturnBLL : ICreate<BorrowReturn>, IUpdate<BorrowReturn>, IDelete, IRead<BorrowReturn>
    {
        BorrowReturnDAL brd = new BorrowReturnDAL();


        public int Add(BorrowReturn obj)
        {
            return brd.Add(obj);
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public BorrowReturn Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<BorrowReturn> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(BorrowReturn obj)
        {
            return brd.Update(obj);
        }
    }
}

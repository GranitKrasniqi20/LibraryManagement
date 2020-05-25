using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxhimiBibliotekes.DAL
{
    public class BorrowDAL : ICreate<Borrow>, IUpdate<Borrow>, IDelete, IRead<Borrow>
    {
        public int Add(Borrow obj)
        {
            throw new NotImplementedException();
        }

        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Borrow Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Borrow> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Borrow obj)
        {
            throw new NotImplementedException();
        }
    }

}

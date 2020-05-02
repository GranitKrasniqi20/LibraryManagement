using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.DAL;

namespace MenaxhimiBibliotekes.BLL
{
    public class BillBLL : ICrud<Bill>
    {
        BillDAL _billDAL = new BillDAL();

        public bool Add(Bill obj)
        {
            return _billDAL.Add(obj);
        }

        public bool Delete(int Id)
        {
            return _billDAL.Delete(Id);
        }


        public Bill Get(int Id)
        {
            return Get(Id);
        }


        public List<Bill> GetAll()
        {
            return GetAll();
        }

        public bool Update(Bill obj)
        {
            return _billDAL.Update(obj);
        }
    }
}

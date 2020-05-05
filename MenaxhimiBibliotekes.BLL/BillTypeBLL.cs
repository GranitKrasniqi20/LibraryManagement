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
    public class BillTypeBLL :  ICreate<BillType>, IUpdate<BillType>, IDelete, IRead<BillType>
    {
        BillTypeDAL billTypeDAL = new BillTypeDAL();

        public int Add(BillType obj)
        {
            return billTypeDAL.Add(obj);
        }

        public int Delete(int Id)
        {
            return billTypeDAL.Delete(Id);
        }

        public BillType Get(int Id)
        {
            return Get(Id);
        }



        public List<BillType> GetAll()
        {
            return GetAll();
        }

        public int Update(BillType obj)
        {
            return billTypeDAL.Update(obj);
        }
    }
}

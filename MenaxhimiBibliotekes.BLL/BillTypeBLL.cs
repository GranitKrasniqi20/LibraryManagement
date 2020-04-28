﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.BO;
using MenaxhimiBibliotekes.DAL;

namespace MenaxhimiBibliotekes.BLL
{
    public class BillTypeBLL : ICrud<BillType>
    {
        BillTypeDAL _billTypeDAL = new BillTypeDAL();

        public bool Add(BillType obj)
        {
            return _billTypeDAL.Add(obj);
        }

        public bool Delete(int Id)
        {
            return _billTypeDAL.Delete(Id);
        }

        public bool Delete(BillType obj)
        {
            throw new NotImplementedException();
        }

        public BillType Get(int Id)
        {
            return Get(Id);
        }

        public BillType Get(BillType obj)
        {
            return Get(obj);
        }

        public List<BillType> GetAll()
        {
            return GetAll();
        }

        public bool Update(BillType obj)
        {
            return _billTypeDAL.Update(obj);
        }
    }
}

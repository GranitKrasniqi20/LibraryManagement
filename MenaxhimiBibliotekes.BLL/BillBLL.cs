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
    public class BillBLL : ICreate<Genre>, IUpdate<Genre>, IDelete, IRead<Genre>
    {
        BillDAL billDAL = new BillDAL();

        public int Add(Bill obj)
        {
            return billDAL.Add(obj);
        }

        public int Delete(int Id)
        {
            return billDAL.Delete(Id);
        }


        public Bill Get(int Id)
        {
            return Get(Id);
        }


        public List<Bill> GetAll()
        {
            return GetAll();
        }

        public int Update(Bill obj)
        {
            return billDAL.Update(obj);
        }
    }
}

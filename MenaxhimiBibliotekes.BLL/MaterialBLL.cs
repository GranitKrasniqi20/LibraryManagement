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
    class MaterialBLL : ICrud<Material>
    {
        MaterialDAL _materialDAL = new MaterialDAL();
        public bool Add(Material obj)
        {
           return _materialDAL.Add(obj);
        }

        public bool Delete(int Id)
        {
           return _materialDAL.Delete(Id);
        }

        public bool Delete(Material obj)
        {
            throw new NotImplementedException();
        }

        public Material Get(int Id)
        {
            return Get(Id);
        }

        public Material Get(Material obj)
        {
            return Get(obj);
        }

        public List<Material> GetAll()
        {
            return GetAll();
        }

        public bool Update(Material obj)
        {
            return _materialDAL.Update(obj);
        }
    }
}

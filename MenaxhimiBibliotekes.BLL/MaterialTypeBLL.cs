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
    public class MaterialTypeBLL : ICrud<MaterialType>
    {
        MaterialTypeDAL mt = new MaterialTypeDAL();
        public bool Add(MaterialType obj)
        {
            return mt.Add(obj);
        }

        public bool Delete(int Id)
        {
           return mt.Delete(Id);
        }



        public MaterialType Get(int Id)
        {
            throw new NotImplementedException();
        }



        public List<MaterialType> GetAll()
        {
            return mt.GetAll();
        }

        public bool Update(MaterialType obj)
        {
            return mt.Update(obj);
        }
    }
}

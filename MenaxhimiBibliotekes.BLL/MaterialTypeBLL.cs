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
    public class MaterialTypeBLL : ICreate<MaterialType>, IUpdate<MaterialType>, IDelete, IRead<MaterialType>
    {
        MaterialTypeDAL mt = new MaterialTypeDAL();


        public List<MaterialType> MostBorrowedMaterialTypes()
        {
            return mt.MostBorrowedMaterialTypes();
        }
        public int Add(MaterialType obj)
        {
            return mt.Add(obj);
        }

        public int Delete(int Id)
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

        public int Update(MaterialType obj)
        {
            return mt.Update(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiBibliotekes.BO.Interfaces;
using MenaxhimiBibliotekes.DAL;
using MenaxhimiBibliotekes.BO;

namespace MenaxhimiBibliotekes.BLL
{
    public class ShelfBLL : ICrud<Shelf>
    {
        ShelfDAL ShelDAL = new ShelfDAL();
        public bool Add(Shelf obj)
        {
          return  ShelDAL.Add(obj);
        }

        public bool Delete(int Id)
        {
            return ShelDAL.Delete(Id);
        }

        public Shelf Get(int Id)
        {
            return ShelDAL.Get(Id);
        }

        public List<Shelf> GetAll()
        {
            return ShelDAL.GetAll();
        }

        public bool Update(Shelf obj)
        {
            return ShelDAL.Update(obj);
        }
    }
}

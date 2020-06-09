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
    public class ShelfBLL : ICreate<Shelf>, IUpdate<Shelf>, IDelete, IRead<Shelf>
    {
        ShelfDAL ShelDAL = new ShelfDAL();


        public int Add(Shelf obj)
        {
            return  ShelDAL.Add(obj);
        }

        public int Delete(int Id)
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

        public int Update(Shelf obj)
        {
            return ShelDAL.Update(obj);
        }
    }
}

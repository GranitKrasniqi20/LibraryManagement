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
    public class GenreBLL : ICreate<Genre>,IUpdate<Genre>,IDelete,IRead<Genre>
    {

        GenreDAL gen = new GenreDAL();
        public int Add(Genre obj)
        {
            return gen.Add(obj);

        }

        public int Delete(int Id)
        {
           return  gen.Delete(Id);
        }

        public bool Delete(Genre obj)
        {
            throw new NotImplementedException();
        }

        public Genre Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Genre Get(Genre obj)
        {
            throw new NotImplementedException();
        }

        public List<Genre> GetAll()
        {
            return gen.GetAll();
        }

        public int Update(Genre obj)
        {
            return gen.Update(obj);
        }
    }
}
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
    class LanguageBLL : ICrud<Language>
    {

        LanguageDAL lang = new LanguageDAL();
        public bool Add(Language obj)
        {
           return lang.Add(obj);
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Language obj)
        {
            throw new NotImplementedException();
        }

        public Language Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Language Get(Language obj)
        {
            throw new NotImplementedException();
        }

        public List<Language> GetAll()
        {
            return lang.GetAll();
        }

        public bool Update(Language obj)
        {
            return lang.Update(obj);
        }
    }
}

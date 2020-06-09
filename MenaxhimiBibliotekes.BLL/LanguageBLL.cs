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
    public class LanguageBLL : ICreate<Language>, IUpdate<Language>, IDelete, IRead<Language>
    {
        LanguageDAL lang = new LanguageDAL();


        public int Add(Language obj)
        {
            return lang.Add(obj);
        }

        public int Delete(int Id)
        {
            return lang.Delete(Id);
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

        public int Update(Language obj)
        {
            return lang.Update(obj);
        }
    }
}
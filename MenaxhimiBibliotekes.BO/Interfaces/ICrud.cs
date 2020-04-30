using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO.Interfaces
{
    public interface ICrud<T>
    {
        bool Add(T obj);
        bool Update(T obj);
        bool Delete(int Id);
        T Get(int Id);
        List<T> GetAll();
    }
}

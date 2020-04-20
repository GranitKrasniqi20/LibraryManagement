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
        bool Delete(T obj);


        T Get(int Id);
        T Get(T obj);

        List<T> GetAll();
    }
}

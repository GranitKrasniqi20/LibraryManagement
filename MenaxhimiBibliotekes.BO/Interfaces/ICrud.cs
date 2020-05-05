using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO.Interfaces
{
    public interface ICrud<T>
    {
        int Add(T obj);
        int Update(T obj);
        int Delete(int Id);
        T Get(int Id);
        List<T> GetAll();
    }
}

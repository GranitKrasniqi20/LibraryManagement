using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO.Interfaces
{
    public interface IRead<T>
    {

        T Get(int Id);
        List<T> GetAll();
    }
}

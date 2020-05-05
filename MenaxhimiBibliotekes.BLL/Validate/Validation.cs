using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    abstract public class Validation<T>
    {

        public abstract bool AllowedObj(T obj);
        public abstract bool ValidateStringLength(string text,int Length);

    }
}

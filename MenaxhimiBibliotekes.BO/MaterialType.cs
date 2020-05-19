using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class MaterialType : Audit
    {
        public int MaterialTypeId { get; set; }
        public string _MaterialType { get; set; }
        public bool isActive { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class MaterialLocation : Audit
    {
        public int LokacioniMaterialitID { get; set; }
        public int RaftiID { get; set; }
        public virtual Shelf Rafti { get; set; }
        public int MaterialiID { get; set; }
        public virtual Material Materiali { get; set; }
    }
}

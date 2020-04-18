using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class LokacioniMaterialit
    {
        public int LokacioniMaterialitID { get; set; }
        public int RaftiID { get; set; }
        public virtual Rafti Rafti { get; set; }
        public int MaterialiID { get; set; }
        public virtual Materiali Materiali { get; set; }
    }
}

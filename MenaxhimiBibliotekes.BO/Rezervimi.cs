using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Rezervimi
    {
        public int RezervimiID { get; set; }
        public int AbonentiID { get; set; }
        public virtual Subscriber Abonenti { get; set; }
        public int MaterialiID { get; set; }
        public virtual Materiali Materiali { get; set; }
        public DateTime DataRezervimit { get; set; }
    }
}

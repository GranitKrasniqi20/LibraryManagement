using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Huazimi
    {
        public int ID { get; set; }
        public int AbonentiID { get; set; }
        public virtual Abonenti Abonenti { get; set; }
        public int RezervimiID { get; set; }
        public virtual Rezervimi Rezervimi { get; set; }
        public int MaterialiID { get; set; }
        public virtual Materiali Materiali { get; set; }
        public int RaftiID { get; set; }
        public virtual Rafti Rafti { get; set; }
        public int TipiVeprimitID { get; set; }
        public virtual TipiVeprimit TipiVeprimit { get; set; }
        public DateTime DataMarrjes { get; set; }
        public DateTime DataKthimit { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Reservation : Audit
    {
        public int reservationId { get; set; }
        public int subscriberId { get; set; }
        public virtual Subscriber _subscriber { get; set; }
        public int MaterialId { get; set; }
        public virtual Material _materiald { get; set; }
        public DateTime reservationDate { get; set; }
    }
}

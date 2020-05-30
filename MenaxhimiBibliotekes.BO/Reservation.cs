using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Reservation : Audit
    {
        public int ReservationId { get; set; }
        public int SubscriberId { get; set; }
        public virtual Subscriber _subscriber { get; set; }
        public int MaterialId { get; set; }
        public virtual Material _material { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}

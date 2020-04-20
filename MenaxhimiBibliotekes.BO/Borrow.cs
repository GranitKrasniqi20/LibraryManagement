using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Borrow : Audit
    {
        public int BorrowId { get; set; }
        public int SubscriberId { get; set; }
        public virtual Subscriber _subscriber { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservation _reservation { get; set; }
        public int materialId { get; set; }
        public virtual Material _material { get; set; }
        public int shelfId { get; set; }
        public virtual Shelf _shelf { get; set; }
        public int _typeOfAction { get; set; }
        public virtual TypeOfAction TypeOfAction { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}

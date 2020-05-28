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
        public string  Comment { get; set; }
        public virtual Subscriber _subscriber { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservation _reservation { get; set; }
        public int materialId { get; set; }
        public virtual Material _material { get; set; }
        public int shelfId { get; set; }
        public virtual Shelf _shelf { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DeadLine { get; set; }
        public BorrowReturn BorrowReturn { get; set; }
        public int BorrowReturnId { get; set; }
        public Borrow()
        {
            ;
            _reservation = new Reservation();
            _material = new Material();
            _shelf = new Shelf();
        }
    }
}

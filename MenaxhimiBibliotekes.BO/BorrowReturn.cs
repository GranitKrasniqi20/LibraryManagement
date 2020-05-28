using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class BorrowReturn:Audit
    {
        public int BorrowReturnId { get; set; }
        public int BorrowId { get; set; }
        public Borrow Borrow { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BillId { get; set; }
        public Bill Bill { get; set; }
        public string Comment { get; set; }
    }
}

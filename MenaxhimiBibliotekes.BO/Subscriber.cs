using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Subscriber : Audit
    {
        public int SubscriberId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string PersonalNo { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int BorrowingsNumber { get; set; }
        public string FullName { get; set; }

    }
}

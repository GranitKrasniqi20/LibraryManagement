using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Bill : Audit
    {
        public int BillId { get; set; }
        public int SubscriberId { get; set; }
        public virtual Subscriber _Subscriber { get; set; }
        public int MaterialId { get; set; }
        public virtual Material _Material { get; set; }
        public int BillTypeId { get; set; }
        public virtual BillType _BillType { get; set; }
        public DateTime BillingDate { get; set; }
        public decimal Price { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Description { get; set; }
    }
}

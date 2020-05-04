using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class BillType : Audit
    {
        public int BillTypeId { get; set; }
        public string _BillType { get; set; }

        public virtual List<Bill> Bills { get; set; }
    }
}

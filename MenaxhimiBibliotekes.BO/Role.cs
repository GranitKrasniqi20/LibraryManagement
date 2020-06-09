using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Role:Audit
    {
        public int UserRoleId { get; set; }
        public string UserRole { get; set; }
    }
}

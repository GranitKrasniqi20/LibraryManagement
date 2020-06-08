using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Notification
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class User
    {
        public int UserID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public int RoliID { get; set; }
        public virtual Roli Roli { get; set; }
        public string Emaili { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

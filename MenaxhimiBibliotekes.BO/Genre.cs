using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Genre : Audit
    {
        public int GenreId { get; set; }
        public string _Genre { get; set; }
        public bool isActive { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Shelf:Audit
    {
        public int ShelfId { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }//Kapaciteti i numrit te librave
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Rafti
    {
        public int RaftiID { get; set; }
        public string Lokacioni { get; set; }
        public int Sasia { get; set; }//Kapaciteti i numrit te librave
        public string Pershkrimi { get; set; }
    }
}

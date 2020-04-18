using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Abonenti
    {
        //Komenti GK
        public int AbonentiID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Adresa { get; set; }
        public DateTime Datelindja { get; set; }
        public string NumriPersonal { get; set; }
        public string Emaili { get; set; }
        public bool Gjinia { get; set; }
        public DateTime DataSkadimit { get; set; }
    }
}

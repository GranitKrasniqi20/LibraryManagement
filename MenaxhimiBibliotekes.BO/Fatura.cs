using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Fatura
    {
        public int FaturaID { get; set; }
        public int AbonentiId { get; set; }
        public virtual Abonenti Abonenti { get; set; }
        public int MaterialiId { get; set; }
        public virtual Materiali Materiali { get; set; }
        public int TipiFaturesID { get; set; }
        public virtual TipiFatures TipiFatures { get; set; }
        public DateTime DataFaturimit { get; set; }
        public decimal Cmimi { get; set; }
        public DateTime DataRegjistrimit { get; set; }
        public DateTime DataSkadimit { get; set; }
        public string Pershkrimi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Materiali
    {
        public int MaterialiID { get; set; }

        public int AutoriID { get; set; }
        public virtual Autori Autori { get; set; }

        public int ZhanriID { get; set; }
        public virtual Zhanri Zhanri { get; set; }

        public int ShtepiaBotueseID { get; set; }
        public virtual ShtepiaBotuese ShtepiaBotuese { get; set; }

        public int LlojiMaterialitID { get; set; }
        public virtual LlojiMaterialit LlojiMaterialit { get; set; }

        public int GjuhaID { get; set; }
        public virtual Gjuha Gjuha { get; set; }

        public string Titulli { get; set; }
        public DateTime DataBotimit { get; set; }
        public string VendiBotimit { get; set; }
        public string ISBN { get; set; }
        public int KopjeTeLira { get; set; }//Numri Kopjeve te lira
        public int Sasia { get; set; }//Tirazhi
        public int NumriFaqeve { get; set; }
    }
}

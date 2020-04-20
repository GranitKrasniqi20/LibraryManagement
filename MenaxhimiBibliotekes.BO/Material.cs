using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Material : Audit
    {
        public int MaterialId { get; set; }


        public int GenreId { get; set; }
        public virtual Genre _Genre { get; set; }

        public int PublishHouseId { get; set; }
        public virtual PublishHouse _PublishHouse { get; set; }

        public int MaterialTypeId { get; set; }
        public virtual MaterialType _MaterialType { get; set; }

        public int LangluageId { get; set; }
        public virtual Language _Language { get; set; }

        public string Title { get; set; }
        public DateTime PublishYear { get; set; }
        public string PublishPlace { get; set; }
        public string ISBN { get; set; }
        public int AvailableCoppies { get; set; }//Numri Kopjeve te lira
        public int Quantity { get; set; }//Tirazhi
        public int NumberOfPages { get; set; }


        List<Author> Authors { get; set; } = new List<Author>();
    }
}

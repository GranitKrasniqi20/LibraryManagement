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
        public virtual Genre _Genre { get; set; }
        public virtual PublishHouse _PublishHouse { get; set; }
        public virtual Author _Author { get; set; }
        public virtual MaterialType _MaterialType { get; set; }
        public virtual Language _Language { get; set; }
        public string Title { get; set; }
        public DateTime PublishYear { get; set; }
        public string PublishPlace { get; set; }
        public string ISBN { get; set; }
        public int AvailableCoppies { get; set; }//Numri Kopjeve te liraC:\Users\ET\Desktop\MenaxhimiBibliotekes\MenaxhimiBibliotekes.BO\Material.cs
        public int Quantity { get; set; }//Tirazhi
        public int NumberOfPages { get; set; }
        public bool IsActive { get; set; }

        public List<Shelf> Shelves { get; set; } = new List<Shelf>();
    }
}

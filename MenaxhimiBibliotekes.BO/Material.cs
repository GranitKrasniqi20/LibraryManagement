using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BO
{
    public class Material : Audit
    {
        public Material()
        {
            _Genre = new Genre();
            _PublishHouse = new PublishHouse();
            _Author = new Author();
            _MaterialType = new MaterialType();
            _Language = new Language();
            _Shelf = new Shelf();
        }

        public int MaterialId { get; set; }
        public int GenreId { get; set; }
        public virtual Genre _Genre { get; set; }
        public int PublishHouseId { get; set; }
        public virtual PublishHouse _PublishHouse { get; set; }
        public int AuthorId { get; set; }
        public virtual Author _Author { get; set; }
        public int MaterialTypeId { get; set; }
        public virtual MaterialType _MaterialType { get; set; }
        public int LanguageId { get; set; }
        public virtual Language _Language { get; set; }
        public string Title { get; set; }
        public DateTime PublishYear { get; set; }
        public string PublishPlace { get; set; }
        public string ISBN { get; set; }
        public int AvailableCoppies { get; set; }//Numri Kopjeve te liraC:\Users\ET\Desktop\MenaxhimiBibliotekes\MenaxhimiBibliotekes.BO\Material.cs
        public int Quantity { get; set; }//Tirazhi
        public int NumberOfPages { get; set; }
        public bool IsActive { get; set; }
        public int ShelfId { get; set; }
        public virtual Shelf _Shelf { get; set; }
    }
}

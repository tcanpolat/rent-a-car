using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Entity
{
    public class Kiralama : BaseEntity
    {
        public int ArabaID { get; set; }
        public int YoneticiID { get; set; }
        public virtual Araba Araba { get; set; } // ilişkisel bağlantı navigation property
        public virtual Yonetici Yonetici { get; set; } // ilişkisel bağlantı navigation property
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int KiralamaSuresi { get; set; }
        public double FaturaTutari { get; set; }
    }
}

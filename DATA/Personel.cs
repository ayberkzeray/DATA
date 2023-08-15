using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TCKimlikNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string IsimSoyisim { get { return Isim + " " + Soyisim; } }
        public string Birim { get; set; }

        public virtual IletisimBilgisi IletisimBilgisi { get; set; }
    }
}

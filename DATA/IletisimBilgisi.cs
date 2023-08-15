using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class IletisimBilgisi
    {
        public int PersonelID { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public string TestString { get; set; } = "";

        public virtual Personel Personel { get; set; }
    }
}

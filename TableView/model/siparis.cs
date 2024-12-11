using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class siparis
    {
        public int faturaKod { get; set; }
        public int kullaniciKod { get; set; }
        public string faturaAdresi { get; set; }
        public string vergiDairesi { get; set; }
        public string vergiNo { get; set; }
        public int siparisDurumKod { get; set; }
        public DateTime siparisTarih { get; set; }

        public siparis (int faturaKod, int kullaniciKod, string faturaAdresi, string vergiDairesi, string vergiNo, int siparisDurumKod, DateTime siparisTarih)
        {
            this.faturaKod = faturaKod;
            this.kullaniciKod = kullaniciKod;
            this.faturaAdresi = faturaAdresi;
            this.vergiDairesi = vergiDairesi;
            this.vergiNo = vergiNo;
            this.siparisDurumKod = siparisDurumKod;
            this.siparisTarih = siparisTarih;
        }
    }
}

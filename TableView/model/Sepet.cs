using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Sepet
    {
        public int kullaniciKod { get; set; }
        public int urunKod { get; set; }
        public int adet { get; set; }

        public Sepet(int kullaniciKod, int urunKod, int adet)
        {
            this.kullaniciKod = kullaniciKod;
            this.urunKod = urunKod;
            this.adet = adet;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Urun_Reyon
    {
        public long ReyonKod { get; set; }
        public int UrunKod { get; set; }
        public int Siralama { get; set; }

        public Urun_Reyon(long reyonKod, int urunKod, int siralama)
        {
            ReyonKod = reyonKod;
            UrunKod = urunKod;
            Siralama = siralama;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class SiparisDetay
    {
        public int SatirNo { get; set; }
        public int faturaKod { get; set; }
        public int urunKod { get; set; }
        public float fiyat { get; set; }
        public float KDV { get; set; }
        public short adet { get; set; }

        public SiparisDetay (int satirNo, int faturaKod, int urunKod, float fiyat, float kDV, short adet)
        {
            SatirNo = satirNo;
            this.faturaKod = faturaKod;
            this.urunKod = urunKod;
            this.fiyat = fiyat;
            KDV = kDV;
            this.adet = adet;
        }
    }
}

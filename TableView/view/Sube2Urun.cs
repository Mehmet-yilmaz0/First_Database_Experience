using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Sube2Urun
    {
        public short subeKod { get; set; }
        public int urunKod { get; set; }
        public string urunAd { get; set; }

        public Sube2Urun(short subeKod, int urunKod, string urunAd)
        {
            this.subeKod = subeKod;
            this.urunKod = urunKod;
            this.urunAd = urunAd;
        }
    }
}

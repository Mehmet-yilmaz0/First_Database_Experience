using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Reyon
    {
        public long reyonKod { get; set; }
        public string reyonAd { get; set; }
        public string reyonAciklama { get; set; }
        public long anaReyonKod { get; set; }
        public string Banner { get; set; }
        public bool aktifMi { get; set; }
        public int siralama { get; set; }
        public int sorumluPersonel { get; set; }

        public Reyon(long reyonKod, string reyonAd, string reyonAciklama, long anaReyonKod, string banner, bool aktifMi, int siralama, int sorumluPersonel)
        {
            this.reyonKod = reyonKod;
            this.reyonAd = reyonAd;
            this.reyonAciklama = reyonAciklama;
            this.anaReyonKod = anaReyonKod;
            Banner = banner;
            this.aktifMi = aktifMi;
            this.siralama = siralama;
            this.sorumluPersonel = sorumluPersonel;
        }
    }
}

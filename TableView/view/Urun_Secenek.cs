using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Urun_Secenek
    {
        public int urunKod { get; set; }
        public int secenekKod { get; set; }
        public string secenekDeger { get; set; }
        public bool aktifMi { get; set; }

        public Urun_Secenek(int urunKod, int secenekKod, string secenekDeger, bool aktifMi)
        {
            this.urunKod = urunKod;
            this.secenekKod = secenekKod;
            this.secenekDeger = secenekDeger;
            this.aktifMi = aktifMi;
        }
    }
}

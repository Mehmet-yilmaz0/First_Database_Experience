using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Urun_Ozellik
    {
        public int urunKod { get; set; }
        public int ozellikKod { get; set; }
        public string deger { get; set; }

        public Urun_Ozellik(int urunKod, int ozellikKod, string deger)
        {
            this.urunKod = urunKod;
            this.ozellikKod = ozellikKod;
            this.deger = deger;
        }
    }
}

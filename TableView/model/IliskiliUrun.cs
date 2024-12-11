using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class IliskiliUrun
    {
        public int urunKod { get; set; }
        public int ilsUrunKod { get; set; }
        public bool ciftYon { get; set; }

        public IliskiliUrun(int urunKod, int ilsUrunKod, bool ciftYon)
        {
            this.urunKod = urunKod;
            this.ilsUrunKod = ilsUrunKod;
            this.ciftYon = ciftYon;
        }
    }
}

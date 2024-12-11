using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Stok
    {
        public Guid urunKod { get; set; }
        public string urunIsim { get; set; }

        public Stok(Guid urunKod, string urunIsim)
        {
            this.urunKod = urunKod;
            this.urunIsim = urunIsim;
        }
    }
}

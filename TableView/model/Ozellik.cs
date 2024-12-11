using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Ozellik
    {
        public int ozellikKod { get; set; }
        public string ozellik { get; set; }
        public bool baSayisal { get; set; }

        public Ozellik( int ozellikKod, string ozellik, bool baSayisal)
        {
            this.ozellikKod = ozellikKod;
            this.ozellik = ozellik;
            this.baSayisal = baSayisal;
        }
    }
}

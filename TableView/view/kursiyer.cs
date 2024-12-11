using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class kursiyer
    {
        public string isim { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }

        public kursiyer(string isim, string soyad, string telefon)
        {
            this.isim = isim;
            this.soyad = soyad;
            this.telefon = telefon;
        }
    }
}

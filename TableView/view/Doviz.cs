using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Doviz
    {
        public string dovizKod { get; set; }
        public string dovizAd { get; set; }
        public float dovizOran { get; set; }

        public Doviz(string dovizKod, string dovizAd, float dovizOran)
        {
            {
                this.dovizKod = dovizKod;
                this.dovizAd = dovizAd;
                this.dovizOran = dovizOran;
            }
        }
    }
}
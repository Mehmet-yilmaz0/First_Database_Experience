using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Marka
    {
        public int markaKod { get; set; }
        public string MarkaName { get; set; }
        public string MarkaWeb { get; set; }
        public string MarkaMail { get; set; }
        public string MarkaTel { get; set; }
        public string MarkaResim { get; set; }

        public Marka(int markaKod, string markaName, string markaWeb, string markaMail, string markaTel, string markaResim)
        {
            this.markaKod = markaKod;
            MarkaName = markaName;
            MarkaWeb = markaWeb;
            MarkaMail = markaMail;
            MarkaTel = markaTel;
            MarkaResim = markaResim;
        }
    }
}

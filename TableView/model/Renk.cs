using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Renk
    {
        public int renkKod { get; set; }
        public string RenkName { get; set; }

        public Renk(int renkKod, string renkName)
        {
            this.renkKod = renkKod;
            RenkName = renkName;
        }
    }
}

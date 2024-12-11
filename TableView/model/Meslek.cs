using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Meslek
    {
        public int meslekKod { get; set; }
        public string meslekName { get; set; }

        public Meslek(int meslekKod, string meslekName)
        {
            this.meslekKod = meslekKod;
            this.meslekName = meslekName;
        }
    }
}

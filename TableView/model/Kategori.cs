using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Kategori
    {
        public string title { get; set; }
        public string descr { get; set; }
        public int mainCatID { get; set; }
        public bool isActive { get; set; }
        public int orderer { get; set; }
        public bool ismenu { get; set; }
        public string extURL { get; set; }
        public int sorumluPersonel { get; set; }

        public Kategori(string title, string descr, int mainCatID, bool isActive, int orderer, bool ismenu, string extURL, int sorumluPersonel)
        {
            this.title = title;
            this.descr = descr;
            this.mainCatID = mainCatID;
            this.isActive = isActive;
            this.orderer = orderer;
            this.ismenu = ismenu;
            this.extURL = extURL;
            this.sorumluPersonel = sorumluPersonel;
        }
    }
}

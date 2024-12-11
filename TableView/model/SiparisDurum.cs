using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class SiparisDurum
    {
        public int siparisDurumKod { get; set; }
        public string aciklama { get; set; }
        public bool aktifMi { get; set; }

        public SiparisDurum(int siparisDurumKod, string aciklama, bool aktifMi)
        {
            this.siparisDurumKod = siparisDurumKod;
            this.aciklama = aciklama;
            this.aktifMi = aktifMi;
        }
    }
}

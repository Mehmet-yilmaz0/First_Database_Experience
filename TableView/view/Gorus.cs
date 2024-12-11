using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Gorus
    {
        public int gorusKod { get; set; }
        public int urunKod { get; set; }
        public int kullaniciKod { get; set; }
        public string Baslik { get; set; }
        public string icerik { get; set; }
        public string ip { get; set; }
        public bool aktifMi { get; set; }
        public DateTime Tarih { get; set; }
        public int katilan { get; set; }
        public int katilmayan { get; set; }

        public Gorus(int gorusKod, int urunKod, int kullaniciKod, string baslik, string icerik, string ip, bool aktifMi, DateTime tarih, int katilan, int katilmayan)
        {
            this.gorusKod = gorusKod;
            this.urunKod = urunKod;
            this.kullaniciKod = kullaniciKod;
            Baslik = baslik;
            this.icerik = icerik;
            this.ip = ip;
            this.aktifMi = aktifMi;
            Tarih = tarih;
            this.katilan = katilan;
            this.katilmayan = katilmayan;
        }
    }
}

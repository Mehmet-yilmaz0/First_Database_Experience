using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Urun
    {
        public int urunKod { get; set; }
        public string Barkod { get; set; }
        public int bolgeKod { get; set; }
        public int markaKod { get; set; }
        public string urunAd { get; set; }
        public float bayiFiyat { get; set; }
        public float listeFiyat { get; set; }
        public float Indirim { get; set; }
        public float KDVoran { get; set; }
        public string urunResim { get; set; }
        public string urunOzet { get; set; }
        public string urunTanitim { get; set; }
        public string urunDurum { get; set; }
        public string urunOncelik { get; set; }
        public int stokDurum { get; set; }
        public int stopMinimum { get; set; }
        public short stokAmbarKod { get; set; }
        public string garanti { get; set; }
        public string dovizKod { get; set; }
        public long reyonKod { get; set; }
        public string kullanimKlavuzWEB { get; set; }
        public bool baStokDurum { get; set; }
        public short teslimatSure { get; set; }
        public short dagiticiKod { get; set; }
        public float hacimDesi  { get; set; }
        public bool baKarisikKoli { get; set; }
        public short birimKod { get; set; }

        public Urun(int urunKod, string barkod, int bolgeKod, int markaKod, string urunAd, float bayiFiyat, float listeFiyat, float ındirim, float kDVoran, string urunResim, string urunOzet, string urunTanitim, string urunDurum, string urunOncelik, int stokDurum, int stopMinimum, short stokAmbarKod, string garanti, string dovizKod, long reyonKod, string kullanimKlavuzWEB, bool baStokDurum, short teslimatSure, short dagiticiKod, float hacimDesi, bool baKarisikKoli, short birimKod)
        {
            this.urunKod = urunKod;
            Barkod = barkod;
            this.bolgeKod = bolgeKod;
            this.markaKod = markaKod;
            this.urunAd = urunAd;
            this.bayiFiyat = bayiFiyat;
            this.listeFiyat = listeFiyat;
            Indirim = ındirim;
            KDVoran = kDVoran;
            this.urunResim = urunResim;
            this.urunOzet = urunOzet;
            this.urunTanitim = urunTanitim;
            this.urunDurum = urunDurum;
            this.urunOncelik = urunOncelik;
            this.stokDurum = stokDurum;
            this.stopMinimum = stopMinimum;
            this.stokAmbarKod = stokAmbarKod;
            this.garanti = garanti;
            this.dovizKod = dovizKod;
            this.reyonKod = reyonKod;
            this.kullanimKlavuzWEB = kullanimKlavuzWEB;
            this.baStokDurum = baStokDurum;
            this.teslimatSure = teslimatSure;
            this.dagiticiKod = dagiticiKod;
            this.hacimDesi = hacimDesi;
            this.baKarisikKoli = baKarisikKoli;
            this.birimKod = birimKod;
        }
    }
}

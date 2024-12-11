using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Kullanici
    {
        public int kullaniciKod { get; set; }
        public string kullaniciAd { get; set; }
        public string email { get; set; }
        public int firmaKod { get; set; }
        public int meslekKod { get; set; }
        public string isim { get; set; }
        public string soyad { get; set; }
        public int yetkiSeviye { get; set; }
        public DateTime sonGirisTarihi { get; set; }
        public int girisSayisi { get; set; }
        public string sifre { get; set; }
        public string ulke { get; set; }
        public string sehir { get; set; }
        public string adres1 { get; set; }
        public string adres2 { get; set; }
        public string tel { get; set; }
        public string fax { get; set; }
        public string faks { get; set; }
        public string postaKod { get; set; }
        public int puan { get; set; }
        public float bakiye { get; set; }
        public string vergiDairesi { get; set; }
        public string vergiNo { get; set; }
        public DateTime olTarih { get; set; }
        public bool aktifMi { get; set; }
Kullanici(int kullaniciKod, string kullaniciAd, string email, int firmaKod, int meslekKod, string isim, string soyad, int yetkiSeviye, DateTime sonGirisTarihi, int girisSayisi, string sifre, string ulke, string sehir, string adres1, string adres2, string tel, string fax, string faks, string postaKod, int puan, float bakiye, string vergiDairesi, string vergiNo, DateTime olTarih, bool aktifMi)
        {
            this.kullaniciKod = kullaniciKod;
            this.kullaniciAd = kullaniciAd;
            this.email = email;
            this.firmaKod = firmaKod;
            this.meslekKod = meslekKod;
            this.isim = isim;
            this.soyad = soyad;
            this.yetkiSeviye = yetkiSeviye;
            this.sonGirisTarihi = sonGirisTarihi;
            this.girisSayisi = girisSayisi;
            this.sifre = sifre;
            this.ulke = ulke;
            this.sehir = sehir;
            this.adres1 = adres1;
            this.adres2 = adres2;
            this.tel = tel;
            this.fax = fax;
            this.faks = faks;
            this.postaKod = postaKod;
            this.puan = puan;
            this.bakiye = bakiye;
            this.vergiDairesi = vergiDairesi;
            this.vergiNo = vergiNo;
            this.olTarih = olTarih;
            this.aktifMi = aktifMi;
        }
    }
}

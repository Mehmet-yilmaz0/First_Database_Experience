using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Hesap
    {
        int _hesapNo;
        string _isim;
        string _soyad;
        int _sube;
        float _bakiye;
        public int HesapNo { get { return _hesapNo; } set { _hesapNo = value; } }
        public string isim { get { return _isim; } set { _isim = value; } }
        public string soyad { get { return _soyad; } set { _soyad = value; } }
        public int sube { get { return _sube; } set { _sube = value; } }
        public float bakiye { get { return _bakiye; } set { _bakiye = value; } }
        public Hesap(int hesapNo, string isim, string soyad, int sube, float bakiye)
        {
            _hesapNo = hesapNo;
            _isim = isim;
            _soyad = soyad;
            _sube = sube;
            _bakiye = bakiye;
        }
    }
}

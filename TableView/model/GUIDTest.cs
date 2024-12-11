using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    public class GUIDTest
    {
        private int _no;
        private string _name;
        public int numara
        {
            get { return _no; }
        }
        public string isim
        {
            get { return _name; }
        }
        public GUIDTest(int numara,string isim) 
        {
            _no = numara;
            _name = isim;
        }

    }
}

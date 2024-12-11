using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Eliste
    {
        public string email { get; set; }
        public bool isActive { get; set; }

        public Eliste(string email, bool isActive)
        {
            this.email = email;
            this.isActive = isActive;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SqlDers.modell
{
    internal class testTimestamp
    {
        public string value { get; set; }
        public byte[] auto_rv { get; set; }

        public testTimestamp(string value, byte[] auto_rv)
        {
            this.value = value;
            this.auto_rv = auto_rv;
        }
    }
}
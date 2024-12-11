using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Etc
    {
        public string etcID { get; set; }
        public string etcText { get; set; }
        public int etcNumber {  get; set; }
        public string desc { get; set; }

        public Etc(string etcID, string etcText, int etcNumber, string desc)
        {
            {
                this.etcID = etcID;
                this.etcText = etcText;
                this.etcNumber = etcNumber;
                this.desc = desc;
            }
        }
    }
}

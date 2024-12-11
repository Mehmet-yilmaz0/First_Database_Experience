using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDers.modell
{
    internal class Model
    {
        public int ModelKod { get; set; }
        public string Marka { get; set; }
        public string modelName { get; set; }

        public Model(int modelKod, string marka, string modelName)
        {
            ModelKod = modelKod;
            Marka = marka;
            this.modelName = modelName;
        }
    }
}

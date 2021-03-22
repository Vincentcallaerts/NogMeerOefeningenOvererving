using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    abstract class GeometricFigure 
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }

        private int oppervlakte;

        public int Oppervlakte
        {
            get { return BerekenOppervlakte(); }
            private set { oppervlakte = BerekenOppervlakte(); }
        }
        public abstract int BerekenOppervlakte();
    }
}

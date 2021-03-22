using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    class Vierkant : Rechthoek
    {
        public Vierkant(int alles)
        {
            Hoogte = alles;
            Breedte = alles;
        }
        public Vierkant(int getal1, int getal2)
        {

            Hoogte = getal1;
            Breedte = getal1;

        }
    }
}

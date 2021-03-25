using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    class Rechthoek : GeometricFigure, IComparable
    {
        public override int BerekenOppervlakte()
        {

            return Breedte * Hoogte;
        }

        public int CompareTo(object obj)
        {
            Rechthoek temp = obj as Rechthoek;
            if (temp != null)
            {
                return Oppervlakte.CompareTo(temp.Oppervlakte);
            }
            return 0;
        }
    }
}

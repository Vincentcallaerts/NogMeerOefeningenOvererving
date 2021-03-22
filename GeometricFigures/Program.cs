using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {

            Rechthoek rechthoek = new Rechthoek();
            rechthoek.Breedte = 4;
            rechthoek.Hoogte = 5;
            Vierkant vierkant1 = new Vierkant(4);
            Vierkant vierkant2 = new Vierkant(4,9);
            Driehoek driehoek = new Driehoek();
            driehoek.Breedte = 4;
            driehoek.Hoogte = 5;

            Console.WriteLine(rechthoek.Oppervlakte);
            Console.WriteLine(vierkant1.Oppervlakte);
            Console.WriteLine(vierkant2.Oppervlakte);
            Console.WriteLine(driehoek.Oppervlakte);
            Console.ReadLine();
        }
    }
}

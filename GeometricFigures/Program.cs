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

            Rechthoek rechthoek1 = new Rechthoek();
            rechthoek1.Breedte = 10;
            rechthoek1.Hoogte = 5;
            Rechthoek rechthoek2 = new Rechthoek();
            rechthoek2.Breedte = 4;
            rechthoek2.Hoogte = 5;
            Rechthoek rechthoek3 = new Rechthoek();
            rechthoek3.Breedte = 6;
            rechthoek3.Hoogte = 5;
            Rechthoek rechthoek4 = new Rechthoek();
            rechthoek4.Breedte = 4;
            rechthoek4.Hoogte = 7;


            List<Rechthoek> rechthoeken = new List<Rechthoek>();
            rechthoeken.Add(rechthoek1);
            rechthoeken.Add(rechthoek2);

            rechthoeken.Add(rechthoek3);

            rechthoeken.Add(rechthoek4);

            rechthoeken.Sort();

            foreach (var item in rechthoeken)
            {
                Console.WriteLine(item.Oppervlakte);
            }

            Vierkant vierkant1 = new Vierkant(4);
            Vierkant vierkant2 = new Vierkant(4,9);
            Driehoek driehoek = new Driehoek();
            driehoek.Breedte = 4;
            driehoek.Hoogte = 5;

            
           
            Console.ReadLine();
        }
    }
}

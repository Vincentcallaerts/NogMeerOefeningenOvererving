using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogEenBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankRekening bankrekening = new BankRekening();
            SpaarRekening spaar = new SpaarRekening();
            ProRekening pro = new ProRekening();
            bankrekening.VoegGeldToe(50);
            spaar.VoegGeldToe(500);
            pro.VoegGeldToe(5000);
            Console.WriteLine(bankrekening.BerekenRente());
            Console.WriteLine(spaar.BerekenRente());
            Console.WriteLine(pro.BerekenRente());
            Console.ReadLine();
        }
    }
}

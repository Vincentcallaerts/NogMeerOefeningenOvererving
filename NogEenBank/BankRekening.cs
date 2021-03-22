using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogEenBank
{
    class BankRekening : Rekening
    {
        public override double BerekenRente()
        {
            if (Saldo >100)
            {
                return Saldo * 0.05;
            }
            return 0;
        }

        
    }
}

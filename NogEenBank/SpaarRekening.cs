using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogEenBank
{
    class SpaarRekening : Rekening
    {
        public override double BerekenRente()
        {
            return Saldo*0.02;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogEenBank
{
    class ProRekening : SpaarRekening
    {
        public override double BerekenRente()
        {

            return base.BerekenRente() + (Saldo/1000)*10;
        }
    }
}

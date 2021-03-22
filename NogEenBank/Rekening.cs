using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NogEenBank
{
    abstract class Rekening
    {
        private int slado;

        public int Saldo
        {
            get { return slado; }
            private set { slado = value; }
        }

        public void VoegGeldToe(int saldo)
        {
            Saldo += saldo;
        }
        public void HaalGeldAf(int saldo)
        {
            Saldo -= saldo;
        }

        public abstract double BerekenRente();

    }
}

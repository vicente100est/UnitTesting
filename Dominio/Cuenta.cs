using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cuenta
    {
        private Persona titular;

        public Cuenta(Persona titular)
        {
            this.titular = titular;
        }

        public double Saldo { get; private set; }

        public void Acreditar(double monto)
        {
            if (monto < 0)
            {
                throw new Exception();
            }
            this.Saldo += monto;
        }

        public void Debitar(double monto)
        {
            this.Saldo -= monto;
        }
    }
}

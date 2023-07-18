using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Test
{
    public class CuentaTest
    {
        private Cuenta cuenta;

        /// <summary>
        /// Setup evita codigo repetido
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            var titular = new Persona("Juan");
            this.cuenta = new Cuenta(titular);
        }

        [Test]
        [Category("Ejemplos")]
        public void AcreditarUnMontoNegativoNoEsValido()
        {
            var montoNegativo = -10;

            Assert.Throws<Exception>(() => this.cuenta.Acreditar(montoNegativo));
        }

        [Test]
        public void SeCreaConSaldoCero()
        {
            Assert.AreEqual(0, cuenta.Saldo);
        }

        [Test]
        public void DebitarDecrementaElSaldo()
        {
            var monto = 10;
            var saldoFinalEsperado = this.cuenta.Saldo - monto;

            this.cuenta.Debitar(monto);

            Assert.AreEqual(saldoFinalEsperado, this.cuenta.Saldo);
        }
    }
}

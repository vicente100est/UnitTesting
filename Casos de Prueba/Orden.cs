using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casos_de_Prueba
{
    [TestFixture]
    public class Orden
    {
        [Test, Order(2)]
        //Categorizar los test para ordenarlos
        [Category("Ejemplos")]
        public void Test1()
        {
            Console.WriteLine("Test1");
        }

        [Test, Order(1)]
        public void Test2()
        {
            Console.WriteLine("Test2");
        }
    }
}

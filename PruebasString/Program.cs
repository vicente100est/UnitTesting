using System.Reflection;

namespace PruebasString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var metodos = typeof(Program).GetMethods(BindingFlags.Public | BindingFlags.Static);
            var pruebaExitosas = 0;
            var pruebaFallidas = 0;
            foreach (var metodo in metodos)
            {
                if (metodo.Name.StartsWith("Prueba"))
                {
                    try
                    {
                        metodo.Invoke(null, null);
                        pruebaExitosas++;
                    }
                    catch
                    {
                        pruebaFallidas++;
                    }
                }
            }


            Console.WriteLine($"Prueba existosas #{pruebaExitosas}");
            Console.WriteLine($"Prueba fallidas #{pruebaFallidas}");
        }

        public static void PruebaQueStringHolaTieneLogitud4()
        {
            //Arrange
            var stringHola = "Hola";

            //Act
            var longitud = stringHola.Length;

            //Assert
            Assert.Que(longitud == 4);
        }

        public static void PruebaQueStringHolaContieneCaracterA()
        {
            //Arrange
            var stringHola = "Hola";

            //Act
            var contieneLetraA = stringHola.Contains("a");

            //Assert
            Assert.Que(contieneLetraA);
        }

        public static void PruebaAreYouVicente()
        {
            //Arrange
            var stringName = "Vicente";

            //Act
            var stringVicente = stringName.Equals("Vicente");

            //Assert
            Assert.Que(stringVicente);
        }
    }
}
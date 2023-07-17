namespace PruebasString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PruebaQueStringHolaTieneLogitud4();
            PruebaQueStringHolaContieneCaracterA();
            Console.WriteLine("Pruebas Exitosas");
        }

        static void PruebaQueStringHolaTieneLogitud4()
        {
            //Arrange
            var stringHola = "Hola";

            //Act
            var longitud = stringHola.Length;

            //Assert
            if (longitud != 4)
            {
                throw new Exception("Prueba fallida");
            }
        }

        static void PruebaQueStringHolaContieneCaracterA()
        {
            //Arrange
            var stringHola = "Hola";

            //Act
            var contieneLetraA = stringHola.Contains("a");

            //Assert
            if (!contieneLetraA)
            {
                throw new Exception("Prueba fallida");
            }
        }
    }
}
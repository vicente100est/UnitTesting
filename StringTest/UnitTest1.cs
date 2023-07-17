namespace StringTest
{
    public class Tests
    {
        [Test]
        public void StringHolaTieneLogitud4()
        {
            //Arrange
            var stringHola = "Hola";

            //Act
            var longitud = stringHola.Length;

            //Assert
            Assert.AreEqual(4, longitud);
        }

        [Test]
        public void StringHolaContieneCaracterA()
        {
            //Arrange
            var stringHola = "Hola";

            //Act
            var contieneLetraA = stringHola.Contains("a");

            //Assert
            Assert.IsTrue(contieneLetraA);
        }

        [Test]
        public void AreYouVicente()
        {
            //Arrange
            var stringName = "Vicente";

            //Act
            var stringVicente = stringName.Equals("Vicente");

            //Assert
            Assert.IsTrue(stringVicente);
        }
    }
}
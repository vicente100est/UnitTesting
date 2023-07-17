namespace StringTest
{
    public class Tests
    {
        [Test]
        public void TestQuePasa()
        {
            //Pasa
            Assert.Pass();
        }

        [Test]
        public void TestInconcluso()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void TestIgnorado()
        {
            Assert.Ignore();
        }

        [Test]
        public void StringHolaTieneLogitud4()
        {
            //Arrange
            var stringHola = "Hola";

            //Act
            var longitud = stringHola.Length;

            //Assert
            Assert.AreEqual(1, longitud);
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
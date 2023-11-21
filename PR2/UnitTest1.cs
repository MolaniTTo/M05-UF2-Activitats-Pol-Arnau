using Metodes;
namespace Unit_Testing_M05_UF2_Activitats
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            int num1 = 5, num2 = 2;


            //Act
            int result = Pr2.Potencia(num1, num2);

            //Assert

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange

            int num1 = 0, num2 = 0;


            //Act
            int result = Pr2.Potencia(num1, num2);

            //Assert

            Assert.AreEqual(0, result);
        }
    }
}
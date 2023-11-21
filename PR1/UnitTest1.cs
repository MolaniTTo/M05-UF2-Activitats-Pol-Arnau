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

            int num = 5;

            //Act
            bool result = Pr1.Natural(num);

            //Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange

            int num = 0;

            //Act
            bool result = Pr1.Natural(num);

            //Assert

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange

            int num1 = 5, num2 = 10;

            //Act
            string result = Pr1.MesGran(num1, num2);

            //Assert

            Assert.AreEqual("El m�s gran �s el segon", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange

            int num1 = 10, num2 = 5;

            //Act
            string result = Pr1.MesGran(num1, num2);

            //Assert

            Assert.AreEqual("El m�s gran �s el primer", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange

            int num1 = 5, num2 = 5;

            //Act
            string result = Pr1.MesGran(num1, num2);

            //Assert

            Assert.AreEqual("S�n iguals", result);
        }
    }
}
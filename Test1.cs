using Microsoft.VisualStudio.TestTools.UnitTesting;
using KALKULATOR_MATERIA£OWY;

namespace BankTests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMultiplyMethod()
        {
            double result = MainWindow.Multiply(2, 10);

            Assert.AreEqual(result, 20);
        }
              
    }

    [TestClass]
    public class Test2
    {
        [TestMethod]
        public void TestCountPretWagaMethod()
        {
            double result = MainWindow.Count_Pret_Waga(100, 10);

            Assert.AreEqual(result, 0.0785);
        }
    }
}

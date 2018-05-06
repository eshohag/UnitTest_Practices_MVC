using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest_Practices_MVC.Models;

namespace UnitTest_Practices_MVC.Tests.Controllers
{
    [TestClass]
    public class CalculationControllerTest
    {
        [TestMethod]
        public void Addition()
        {
            double expect = 5;
            double actual = Calculator.Addition(2, 3);
            Assert.AreEqual(expect, actual);
        }


        [TestMethod]
        public void Substraction()
        {
            double expect = 2;
            double actual = Calculator.Substraction(4, 2);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Divission()
        {
            double expect = 2;
            double actual = Calculator.Division(2, 4);
            Assert.AreEqual(expect, actual);
        }
    }
}

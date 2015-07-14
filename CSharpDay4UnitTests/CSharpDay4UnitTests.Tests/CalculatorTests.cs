using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDay4UnitTests.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            Calculator calc = new Calculator();
            
            int result = calc.AddNumbers(2, 5);

            Assert.AreEqual(7, result);




        }
    }
}

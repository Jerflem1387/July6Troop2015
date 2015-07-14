using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaxRules.Test
{
    [TestClass]
    public class TaxTests
    {
        [TestMethod]
        public void TestCalculateTodayIsThursday()
        {
            DateTime thursday = DateTime.Now;
            for (int i = 1; i < 8; i++)
            {
                if (thursday.DayOfWeek == DayOfWeek.Tuesday)
                    return;

                thursday = thursday.AddDays(1);
            }

            Tax tax = new Tax(thursday);

            decimal result = tax.Calculate(100, DateTime.Parse("1998-05-18"), "John", "doe");

            Assert.AreEqual(32, result);

        }
    }
}

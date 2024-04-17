using SplitBill_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitBill_Tests
{
    [TestClass]
    public class CalculateTip_Tests
    {
        [TestMethod]
        public void CalculateTipPerPerson_ReturnsCorrectValues()
        {
            // Arrange
            var tipCalc = new CalculateTip();
            var mealCosts = new Dictionary<string, decimal>
            {
                {"Divya", 20.0m},
                {"Joy", 30.0m},
                {"Jessica", 25.0m}
            };
            float tipPercent = 15.0f;

            // Act
            var tipPerPerson = tipCalc.CalculateTipPerPerson(mealCosts, tipPercent);

            // Assert
            Assert.AreEqual(4.5m, tipPerPerson["Divya"]);
            Assert.AreEqual(6.75m, tipPerPerson["Joy"]);
            Assert.AreEqual(5.625m, tipPerPerson["Jessica"]);
        }

        [TestMethod]
        public void CalculateTipPerPerson_ThrowsExceptionIfMealCostsNull()
        {
            // Arrange
            var tipCalc = new CalculateTip();
            Dictionary<string, decimal> mealCosts = null;
            float tipPercent = 15.0f;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => tipCalc.CalculateTipPerPerson(mealCosts, tipPercent));
        }

        [TestMethod]
        public void CalculateTipPerPerson_ThrowsExceptionIftipPercentNegative()
        {
            // Arrange
            var tipCalc = new CalculateTip();
            var mealCosts = new Dictionary<string, decimal>
            {
                {"Divya", 20.0m},
                {"Joy", 30.0m}
            };
            float tipPercent = -5.0f;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => tipCalc.CalculateTipPerPerson(mealCosts, tipPercent));
        }
    }
}

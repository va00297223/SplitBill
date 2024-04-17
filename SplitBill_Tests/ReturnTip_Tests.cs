using SplitBill_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitBill_Tests
{
    [TestClass]
    public class ReturnTip_Tests
    {
        [TestMethod]
        public void CalculateTipPerHead_ReturnsCorrectValue()
        {
            // Arrange
            var tipCalc = new ReturnTip();
            decimal price = 100.0m;
            int NoOfPatrons = 4;
            float tipPercent = 15.0f;
            decimal expectedTipPerHead = 3.75m;

            // Act
            decimal actualTipPerPerson = tipCalc.CalculateTipPerHead(price, NoOfPatrons, tipPercent);

            // Assert
            Assert.AreEqual(expectedTipPerHead, actualTipPerPerson);
        }

        [TestMethod]
        public void CalculateTipPerHead_ThrowsExceptionIfPriceZero()
        {
            // Arrange
            var tipCalc = new ReturnTip();
            decimal price = 0.0m;
            int NoOfPatrons = 4;
            float tipPercent = 15.0f;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => tipCalc.CalculateTipPerHead(price, NoOfPatrons, tipPercent));
        }

        [TestMethod]
        public void CalculateTipPerHead_ThrowsExceptionIfNoOfPatronsZero()
        {
            // Arrange
            var tipCalc = new ReturnTip();
            decimal price = 100.0m;
            int NoOfPatrons = 0;
            float tipPercent = 15.0f;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => tipCalc.CalculateTipPerHead(price, NoOfPatrons, tipPercent));
        }

        [TestMethod]
        public void CalculateTipPerHead_ThrowsExceptionIftipPercentNegative()
        {
            // Arrange
            var tipCalc = new ReturnTip();
            decimal price = 100.0m;
            int NoOfPatrons = 4;
            float tipPercent = -5.0f;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => tipCalc.CalculateTipPerHead(price, NoOfPatrons, tipPercent));
        }
    }
}

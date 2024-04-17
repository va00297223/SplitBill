using SplitBill_Library;

namespace SplitBill_Tests
{
    [TestClass]
    public class Splits_Tests
    {
        [TestMethod]
        public void SplitAmount_ReturnsCorrectValue()
        {
            // Arrange
            var split = new Splits();
            decimal totalBill = 100.0m;
            int NoOfPeople = 4;
            decimal expected = 25.0m;

            // Act
            decimal actual = split.SplitAmount(totalBill, NoOfPeople);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SplitAmount_ThrowsExceptionIfNoOfPeopleZero()
        {
            // Arrange
            var split = new Splits();
            decimal totalBill = 100.0m;
            int NoOfPeople = 0;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => split.SplitAmount(totalBill, NoOfPeople));
        }

        [TestMethod]
        public void SplitAmount_ThrowsExceptionIfNoOfPeopleNegative()
        {
            // Arrange
            var split = new Splits();
            decimal totalBill = 100.0m;
            int NoOfPeople = -1;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => split.SplitAmount(totalBill, NoOfPeople));
        }
    }
}
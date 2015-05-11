using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HappyNumbers.Logic.Tests
{
    [TestClass]
    public class HappyNumbersTests
    {
        [TestMethod]
        public void IsHappyNumber_with_19_should_be_true()
        {
            // Arrange
            
            // Act
            var actual = HappyNumber.IsHappyNumber(19);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsHappyNumber_with_16_should_be_false()
        {
            // Arrange
            
            // Act
            var actual = HappyNumber.IsHappyNumber(16);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}

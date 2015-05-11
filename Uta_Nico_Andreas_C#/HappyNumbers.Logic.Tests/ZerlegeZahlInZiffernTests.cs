using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HappyNumbers.Logic.Tests
{
    [TestClass]
    public class ZerlegeZahlInZiffernTests
    {
        [TestMethod]
        public void ZerlegeZahlInZiffern_with_19()
        {
            // Arrange

            // Act
            var actual = HappyNumber.ZerlegeZahlInZiffern(19);

            // Assert
            var enumerable = actual as int[] ?? actual.ToArray();
            Assert.AreEqual(2, enumerable.Count(), "Es sollten zwei Ziffern geliefert werden");
            Assert.AreEqual(1, enumerable[0], "Die erste Ziffer sollte eine 1 sein");
            Assert.AreEqual(9, enumerable[1], "Die zweite Ziffer sollte eine 9 sein");
        }

        [TestMethod]
        public void ZerlegeZahlInZiffern_mit_100()
        {
            // Arrange
            
            // Act
            var actual = HappyNumber.ZerlegeZahlInZiffern(100);

            // Assert
            var enumerable = actual as int[] ?? actual.ToArray();
            Assert.AreEqual(3, enumerable.Count());
            Assert.AreEqual(1, enumerable[0]);
            Assert.AreEqual(0, enumerable[1]);
            Assert.AreEqual(0, enumerable[2]);
        }
    }
}

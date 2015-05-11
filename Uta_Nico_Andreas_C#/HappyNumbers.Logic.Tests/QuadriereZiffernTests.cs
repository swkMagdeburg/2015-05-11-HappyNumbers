using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HappyNumbers.Logic.Tests
{
    [TestClass]
    public class QuadriereZiffernTests
    {
        [TestMethod]
        public void QuadriereZiffern_sollte_1_und_9_quadrieren()
        {
            // Arrange
            var ziffern = new List<int>();
            ziffern.Add(1);
            ziffern.Add(9);

            // Act
            var actual = HappyNumber.QuadriereZiffern(ziffern).ToArray();

            // Assert
            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(81, actual[1]);
        }

        [TestMethod]
        public void QuadriereZahl_mit_16()
        {
            // Arrange
            var ziffern = new List<int>();
            ziffern.Add(1);
            ziffern.Add(6);

            // Act
            var actual = HappyNumber.QuadriereZiffern(ziffern).ToArray();

            // Assert
            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(36, actual[1]);
        }
    }
}

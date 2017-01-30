using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            OddNumber oddNumber = new OddNumber();

            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void EnsureFirstNumberIsOdd()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act 
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumberPassedPlusOne()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act
            int expectedResult = 3;
            int actualResult = oddNumber.GetNext(1);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

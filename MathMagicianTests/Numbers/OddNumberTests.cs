using System;
using MathMagician.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void EnsureCanCreateOddNumber()
        {
            OddNumber oddNumber = new OddNumber();
            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void CheckOddGetFirstMethod()
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
        public void CheckOddGetNextMethod()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act
            int expectedResult = 7;
            int actualResult = oddNumber.GetNext(5);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckOddGetSequenceMethod()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act
            int[] expectedResult = { 1, 3, 5, 7, 9 };
            int[] actualResult = oddNumber.GetSequence(5);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckOddPrintNumbersMethod()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act
            string expectedResult = "1 3 5 7 9";
            string actualResult = oddNumber.printNumbers(oddNumber.GetSequence(5));

            // Assert
            CollectionAssert.Equals(expectedResult, actualResult);
        }
    }
}

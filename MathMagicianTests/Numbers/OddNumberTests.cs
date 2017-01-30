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

        [TestMethod]
        public void EnsureNumberSequenceIsCorrect()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act
            int[] expectedResult = { 1, 3, 5, 7, 9, 11 };
            int[] actualResult = oddNumber.GetSequence(6);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureStringIsPrinted()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act 
            string expectedResult = "1 3 5 7 9 11";
            string actualResult = evenNumber.PrintNumbers(new[] { 1, 3, 5, 7, 9, 11 });

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

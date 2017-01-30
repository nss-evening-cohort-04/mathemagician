using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        public void EnsureICanCreateOdd()
        {
            OddNumber oddNumber = new OddNumber();

            Assert.IsNotNull(oddNumber);
        }


        [TestMethod]
        public void EnsureOneIsFirstNumber()
        {
            //Arrange
            OddNumber oddNumber = new OddNumber();

            //Act
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFollowingOdd()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act
            int expectedResult = 5;
            int actualResult = oddNumber.GetNext(3);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureOddSequence()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act 
            int[] expectedResult = new int[] { 1, 3, 5, 7, 9 };
            int[] actualResult = oddNumber.GetSequence(5);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintOddSequence()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act
            string expectedResult = "1 3 5 7 9";
            int[] inputArray = new[] { 1, 3, 5, 7, 9 };
            string actualResult = oddNumber.PrintNumbers(inputArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

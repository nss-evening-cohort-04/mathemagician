using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void EnsureICanCrestInstance()
        {
            OddNumber oddNumber = new OddNumber();

            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            OddNumber oddNumber = new OddNumber();

            // Act (Call the method you're testing)
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void EnsureICanGetNext()
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
        public void EnsureICanGetSequence()
        {
            // Arrange
            OddNumber OddNumber = new OddNumber();

            // Act
            int[] expectedResult = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] actualResult = OddNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange
            OddNumber OddNumber = new OddNumber();

            // Act
            string expectedResult = "1 3 5 7 9";
            int[] inputArray = new[] { 1, 3, 5, 7, 9 };
            string actualResult = OddNumber.PrintNumbers(inputArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
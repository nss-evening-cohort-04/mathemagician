using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class PrimeNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            PrimeNumber primeNumber = new PrimeNumber();
            Assert.IsNotNull(primeNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            // Arrange (Where you set stuff up)
            PrimeNumber primeNumber = new PrimeNumber();

            // Act (Call the method you're testing)
            int expectedResult = 1;
            int actualResult = primeNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
        {
            // Arrange
            PrimeNumber primeNumber = new PrimeNumber();

            // Act
            int expectedResult = 11;
            int actualResult = primeNumber.GetNext(7);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            // Arrange
            PrimeNumber primeNumber = new PrimeNumber();

            // Act
            int[] expectedResult = { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            int[] actualResult = primeNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange
            PrimeNumber primeNumber = new PrimeNumber();

            // Act
            string expectedResult = "1 2 3 5 7 11 13 17 19 23";
            int[] inputArray = new[] { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23 };
            string actualResult = primeNumber.PrintNumbers(inputArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
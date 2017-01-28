using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class PrimeNumberTests
    {
        // This is a sanity check test.
        // Ensure everthing is hooked up correctly AND
        // that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            PrimeNumber primeNumber = new PrimeNumber();
            Assert.IsNotNull(primeNumber);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            PrimeNumber primeNumber = new PrimeNumber();

            // Act (Call the method you're testing)
            int expectedResult = 2;
            int actualResult = primeNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextIsTheNextNumber()
        {
            // Arrange (Where you set stuff up)
            PrimeNumber primeNumber = new PrimeNumber();

            // Act (Call the method you're testing)
            int expectedResult = 11;
            int actualResult = primeNumber.GetNext(7);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumsAreRequestedNums()
        {
            // Arrange (Where you set stuff up)
            PrimeNumber primeNumber = new PrimeNumber();

            // Act (Call the method you're testing)
            int[] expectedResult = new int[] { 2, 3, 5};
            int[] actualResult = primeNumber.GetSequence(3);

            // Assert (Check the output from your method)
            CollectionAssert.Equals(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersWork()
        {
            // Arrange (Where you set stuff up)
            PrimeNumber primeNumber = new PrimeNumber();

            // Act (Call the method you're testing)
            string expectedResult = "2 3 5";
            string actualResult = primeNumber.PrintNumbers(primeNumber.GetSequence(3));

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        // This is a sanity check test.
        // Ensure everthing is hooked up correctly AND
        // that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            Assert.IsNotNull(fibonacciNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            // Act (Call the method you're testing)
            int expectedResult = 1;
            int actualResult = fibonacciNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextIsTheNextNumber()
        {
            // Arrange (Where you set stuff up)
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            // Act (Call the method you're testing)
            int expectedResult = 3;
            int actualResult = fibonacciNumber.GetNext(1, 2);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumsAreRequestedNums()
        {
            // Arrange (Where you set stuff up)
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            // Act (Call the method you're testing)
            int[] expectedResult = new int[] { 1, 1, 2, 3 };
            int[] actualResult = fibonacciNumber.GetSequence(4);

            // Assert (Check the output from your method)
            CollectionAssert.Equals(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersWork()
        {
            // Arrange (Where you set stuff up)
           FibonacciNumber fibonacciNumber = new FibonacciNumber();

            // Act (Call the method you're testing)
            string expectedResult = "1 1 2";
            string actualResult =fibonacciNumber.PrintNumbers(fibonacciNumber.GetSequence(3));

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
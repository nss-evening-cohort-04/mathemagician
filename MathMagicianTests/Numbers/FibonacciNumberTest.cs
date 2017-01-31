using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTest
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            Assert.IsNotNull(fibonacciNumber);
        }

        [TestMethod]
        public void EnsureZeroIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            // Act (Call the method you are testing)
            int expectedResult = 0;
            int actualResult = fibonacciNumber.GetFirst();

            // Assert (check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumberInFib()
        {
            // Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            // Act
            int expectedResult = 1;
            int actualResult = fibonacciNumber.GetNext(1);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        [TestMethod]
        public void EnsureNumberSequenceIsCorrect()
        {
            // Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            // Act
            int[] expectedResult = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int[] actualResult = fibonacciNumber.GetSequence(10);

            // Assert
            // Collection.Assert looks at the values inside of the Array of ints
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureStringIsPrinter()
        {
            // Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            // Act 
            string expectedResult = "0 1 1 2 3 5 8 13 21 34";
            string actualResult = fibonacciNumber.PrintNumbers(new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 });

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

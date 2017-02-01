using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void EnsureICanCreatInstance()
        {
            Fibonacci fibonacci = new Fibonacci();
            Assert.IsNotNull(fibonacci);
        }

        [TestMethod]
        public void EnsureTheFirstIsOne()
        {
            //Arrange
            Fibonacci fibonacci = new Fibonacci();

            //Act
            int expectedResult = 1;
            int actualResult = fibonacci.GetFirst();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
        {
            //Arrange
            Fibonacci fibonacci = new Fibonacci();

            //Act
            int expectedResult = 13;
            int actualResult = fibonacci.GetNext(8);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            //Arrange
            Fibonacci fibonacci = new Fibonacci();

            //Act
            int[] expectedResult = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int[] actualResult = fibonacci.GetSequence(10);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            //Arrange
            Fibonacci fibonacci = new Fibonacci();

            //Act
            string expectedResult = "1 1 2 3 5";
            int[] inputArray = new[] { 1, 1, 2, 3, 5 };
            string actualResult = fibonacci.PrintNumbers(inputArray);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

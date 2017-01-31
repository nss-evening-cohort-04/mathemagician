using System;
using MathMagician.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        //Recursive Definition of Fibonacci
        // F3 = F2 + F1
        // F7 = F6 + F5

        [TestMethod]
        public void EnsureICanCreateInstance()
        {

            FibonacciNumber fiboNumber = new FibonacciNumber();
            Assert.IsNotNull(fiboNumber);
           
        }

        [TestMethod]
        public void CheckFiboGetFirstMethod()
        {
            // arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            // Act
            int expectedResult = 1;
            int actualResult = fiboNumber.GetFirst();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckFiboGetNextMethod()
        {
            // Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            // Act
            int expectedResult = 2;
            int actualResult = fiboNumber.GetNext(1);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckFiboGetSequenceMethod()
        {
            // Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            // Act
            int[] expectedResult = { 1, 1};
            int[] actualResult = fiboNumber.GetSequence(2);

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}

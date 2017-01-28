using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTest
    {
        //Recursive Definition for Fibonacci
        //F3 = F2 + F1
        //F7 = F6 + F5
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            Assert.IsNotNull(fiboNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {

            //Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act(call the method you're testing)
            int expectedResult = 1;
            int actualResult = fiboNumber.GetFirst();

            //Assert(Check the output for your method)
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void EnsureICanGetNext()
        {
            //Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act
            int expectedResult = 1;
            int actualResult = fiboNumber.GetNext(1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            //Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act
            int[] expectedResult = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int[] actualResult = fiboNumber.GetSequence(10);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            //Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act
            string expectedResult = "1 1 2 3 5";
            int[] inputArray = new[] { 1, 1, 2, 3, 5 };
            string actualResult = fiboNumber.PrintNumbers(inputArray);
            //string actualResult = fiboNumber.PrintNumbers(new[] { 1, 1, 2, 3, 5 });

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

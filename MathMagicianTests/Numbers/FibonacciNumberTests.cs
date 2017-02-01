using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        //Recursive version of Fibonacci
        //F3 = F2 + F1
        //F7 = F6 + F5

        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            Assert.IsNotNull(fiboNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act
            int expectedResult = 1;
            int actualResult = fiboNumber.GetFirst();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act
            int expectedResult = 8;
            //int myNum; this is 0
            int actualResult = fiboNumber.GetNext(5);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act
            int[] expectedResult = { 1, 1, 2, 3, 5, 8, 13 };
            //int myNum; this is 0
            int[] actualResult = fiboNumber.GetSequence(7);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act 
            string expectedResult = "1 1 2 3 5";
            int[] inputArray = new[] { 1, 1, 2, 3, 5 };
            string actualResult = fiboNumber.PrintNumbers(inputArray);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

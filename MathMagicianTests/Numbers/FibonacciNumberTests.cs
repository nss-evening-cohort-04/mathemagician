using MathMagician.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        //Recursive Definition of Fibonacci
        //F3 = F2 + F1;
        //F7 = F6 + F5;
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            Assert.IsNotNull(fiboNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {

            //Arrange (where you set stuff up)
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int expectedResult = 1;
            int actualResult = fiboNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
        {
            // Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            // Act
            int expectedResult = 8;
            //int myNum; this is zero "0"
            int actualResult = fiboNumber.GetNext(5);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            // Arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            // Act
            int[] expectedResult = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            //int myNum; this is zero "0"
            int[] actualResult = fiboNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            //Arrange (where you set stuff up)
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act (call the method you're testing)
            string expectedResult = "1 1 2 3 5";
            int[] inputArray = new[] { 1, 1, 2, 3, 5 };
            string actualResult = fiboNumber.PrintNumbers(inputArray);


            //Assert (check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

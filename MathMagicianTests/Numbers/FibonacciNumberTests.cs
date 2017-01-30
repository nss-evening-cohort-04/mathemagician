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
        public void EnsureICanCreatInstance()
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
            int expectedResult = 2;
            int actualResult = fiboNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, expectedResult);
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
            //test only one method at a time
            int[] sequenceArray = fiboNumber.GetSequence(10);
            string actualResult = fiboNumber.PrintNumbers(sequenceArray);


            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, "2 4 6 8 10 12 14 16 18 20");

        }
    }
}

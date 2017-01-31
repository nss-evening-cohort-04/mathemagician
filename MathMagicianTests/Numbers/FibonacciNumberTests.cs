﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        //Recursive Definition of Fibonacci Below:
        //Fib3 = Fib2 + Fib1
        //Fib7 = Fib6 + Fib5
        [TestMethod]
        public void EnsureIcanCreateInstance()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            Assert.IsNotNull(fiboNumber);
        }

        [TestMethod]
        public void GetFirstNumberTestMethod4()
        {
            //Arrange (Where you set stuff up)
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //Act (Where you call the method you are testing aka 'GetFirst()' for this example)
            int expectedResult = 1;
            int actualResult = fiboNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void GetNextTestMethod()
        {
            //arrange 
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //act
            int expectedResult = 3;
            int actualResult = fiboNumber.GetNext(1,2);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetSequence()
        {
            //arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //act
            int[] expectedResult = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int[] actualResult = fiboNumber.GetSequence(10);

            //assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Printumberz()
        {
            //arrange
            FibonacciNumber fiboNumber = new FibonacciNumber();

            //act
            string expectedResult = "1 1 2 3 5";
            int[] inputArray = new[] { 1, 1, 2, 3, 5 };
            string actualResult = fiboNumber.PrintNumbers(inputArray);
            //string actualResult = evenNumber.PrintNumbers(new [] { 2, 4, 6, 8, 10 }); aother way of doing things

            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

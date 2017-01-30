using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateFibInstance()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            Assert.IsNotNull(fibonacciNumber);
        }

        [TestMethod]
        public void EnsureICanGetFirstFibNumber()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            int expectedResult = 1;
            int actualResult = fibonacciNumber.GetFirst();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            int expectedResult = 4;
            int actualResult = fibonacciNumber.GetNext(3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetCurrent()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            int expectedResult = 1;
            int actualResult = fibonacciNumber.GetCurrent();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetFibSequence()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            int[] expectedResult = { 1, 1, 2, 3, 5, 8, 13 };
            int[] actualResult = fibonacciNumber.GetSequence(7);

            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintNubers()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            string expectedResult = "1 1 2 3 5 8 13";
            string actualResult = fibonacciNumber.PrintNumbers(new int[] { 1, 1, 2, 3, 5, 8, 13 });

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

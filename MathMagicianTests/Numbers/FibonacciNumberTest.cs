using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTest
    {

        //Recursive Definition
        //F3 = F2 + F1
        //F7 = F6 + F5
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            Assert.IsNotNull(fiboNumber);
        }
    }
}

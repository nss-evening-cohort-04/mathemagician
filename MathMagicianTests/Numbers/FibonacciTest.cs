using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciTest
    {
        //Recursive Definition of Fibonacci
        //F3 =F2 + F1
        //F7 =F6 + F5
        [TestMethod]
        public void EnsureICanCreateInstanceFibonacci()
        {
            FibonacciNumber fiboNumber = new FibonacciNumber();
            Assert.IsNotNull(fiboNumber);
        }

     
        
        }
     

    }


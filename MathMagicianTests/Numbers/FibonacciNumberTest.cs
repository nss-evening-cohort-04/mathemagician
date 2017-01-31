using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTest
    {

        [TestMethod]
        public void EnsureICanCreateInstanceFn()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            Assert.IsNotNull(fibonacciNumber);
        }

        [TestMethod]
        public void EnsureOneIsFirstFn()
        {
            //Arrange
            

            //Assert
            //expectedResult = 1;
            //actualResult = 1;

            //Act

        }
    }
}

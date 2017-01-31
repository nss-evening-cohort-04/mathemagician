using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class PrimeNumberTests
    {
        [TestMethod]
        public void CheckIfICanMakePrimeNumber()
        {
            PrimeNumber primeNumber = new PrimeNumber();
            Assert.IsNotNull(primeNumber);
        }

        [TestMethod]
        public void CheckPrimeGetFirstMethod()
        {
            //Arrange
            PrimeNumber primeNumber = new PrimeNumber();

            // Act
            int expectedResult = 2;
            int actualResult = primeNumber.GetFirst();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckPrimeGetNextMethod()
        {
            // Arrange
            PrimeNumber primeNumber = new PrimeNumber();

            // Act
            int expectedResult = 11;
            int actualResult = primeNumber.GetNext(7);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

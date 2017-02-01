using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class PrimeNumberTests
    {   
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            PrimeNumber primeNumber = new PrimeNumber();

            Assert.IsNotNull(primeNumber);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirst()
        {
            // Arrange
            PrimeNumber primeNumber = new PrimeNumber();

            // Act
            int expectedResult = 2;
            int actualResult = primeNumber.GetFirst();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

// code not finished from here down 1/28 @1:47pm
        [TestMethod]
        public void EnsureNextNumber()
        {
            // Arrange
            PrimeNumber primeNumber = new PrimeNumber();
           
            // Act 
            int expectedResult = 3;
            int actualResult = primeNumber.GetNext(2);
            
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureSequenceIsWorking()
        {
            // Arrange
            PrimeNumber primeNumber = new PrimeNumber();
            
            // Act
            int[] expectedResult = new int[] { 2, 4, 6, 8, 10 };
            int[] actualResult = primeNumber.GetSequence(5);

            // Assert (Check the output from your method)
            // Assert.AreEqual(expectedResult.Length, actualResult.Length);
            // CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersIsWorking()
        {
            //Arrange
            PrimeNumber primeNumber = new PrimeNumber();
            
            //Act 
            string expectedResult = "2 4 6 8 10";
            string actualResult = primeNumber.PrintNumbers(primeNumber.GetSequence(5));
            
            // Assert (Check thte output from your method)
            // Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
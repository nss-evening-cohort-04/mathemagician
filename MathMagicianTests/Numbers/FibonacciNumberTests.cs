using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {   
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            Assert.IsNotNull(fibonacciNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            // Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();

            // Act
            int expectedResult = 1;
            int actualResult = fibonacciNumber.GetFirst();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumber()
        {
            // Arrange
            EvenNumber fibonacciNumber = new EvenNumber();
           
            // Act 
            int expectedResult = 2 + 2;
            int actualResult = fibonacciNumber.GetNext(2);
            
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureSequenceIsWorking()
        {
            // Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            
            // Act
            int[] expectedResult = new int[] { 1, 1, 2, 3, 5 };
            int[] actualResult = fibonacciNumber.GetSequence(5);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersIsWorking()
        {
            //Arrange
            FibonacciNumber fibonacciNumber = new FibonacciNumber();
            
            //Act 
            string expectedResult = "1 1 2 3 5";
            string actualResult = fibonacciNumber.PrintNumbers(fibonacciNumber.GetSequence(5));
            
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
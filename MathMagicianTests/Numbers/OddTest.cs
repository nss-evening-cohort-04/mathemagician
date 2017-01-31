
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        
        [TestMethod]
        public void EnsureICanCreateInstanceOdd()
        {
            OddNumber oddNumber = new OddNumber();
            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void EnsureICanGetTheNextNumberOdd()
        {
            // Arrange 
            OddNumber oddNumber = new OddNumber();

            // Act 
            int expectedResult = 5;
            int actualResult = oddNumber.GetNext(3);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumsAreRequestedNumsOdd()
        {
            // Arrange 
            OddNumber oddNumber = new OddNumber();

            // Act
            int[] expectedResult = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] actualResult = oddNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersWorkOdd()
        {
            // Arrange 
            OddNumber oddNumber = new OddNumber();

            // Act 
            string expectedResult = "1 3 5 7 9";
            int[] inputArray = new[] { 1, 3, 5, 7, 9 };
            string actualResult = oddNumber.PrintNumbers(inputArray);

            // Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


    }

       
    }

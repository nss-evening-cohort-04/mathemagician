using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {   
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            OddNumber oddNumber = new OddNumber();

            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirst()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();

            // Act
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumber()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();
           
            // Act 
            int expectedResult = 1 + 2;
            int actualResult = oddNumber.GetNext(1);
            
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureSequenceIsWorking()
        {
            // Arrange
            OddNumber oddNumber = new OddNumber();
            
            // Act
            int[] expectedResult = new int[] { 1, 3, 5, 7, 9 };
            int[] actualResult = oddNumber.GetSequence(5);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersIsWorking()
        {
            //Arrange
            OddNumber evenNumber = new OddNumber();
            
            //Act 
            string expectedResult = "1 3 5 7 9";
            string actualResult = evenNumber.PrintNumbers(evenNumber.GetSequence(5));
            
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
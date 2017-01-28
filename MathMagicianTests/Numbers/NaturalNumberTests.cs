using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {   
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumber()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();
           
            // Act 
            int expectedResult = 2 + 1;
            int actualResult = naturalNumber.GetNext(2);
            
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureSequenceIsWorking()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();
            
            // Act
            int[] expectedResult = new int[] { 1, 2, 3, 4, 5 };
            int[] actualResult = naturalNumber.GetSequence(5);
            
            // Assert (Check thte output from your method)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersIsWorking()
        {
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();
            
            //Act 
            string expectedResult = "1 2 3 4 5";
            string actualResult = naturalNumber.PrintNumbers(naturalNumber.GetSequence(5));
            
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
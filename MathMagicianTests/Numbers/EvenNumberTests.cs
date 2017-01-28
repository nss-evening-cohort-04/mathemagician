using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {   
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirst()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumber()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();
           
            // Act 
            int expectedResult = 2 + 2;
            int actualResult = evenNumber.GetNext(2);
            
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureSequenceIsWorking()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();
            
            // Act
            int[] expectedResult = new int[] { 2, 4, 6, 8, 10 };
            int[] actualResult = evenNumber.GetSequence(5);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsurePrintNumbersIsWorking()
        {
            //Arrange
            EvenNumber evenNumber = new EvenNumber();
            
            //Act 
            string expectedResult = "2 4 6 8 10";
            string actualResult = evenNumber.PrintNumbers(evenNumber.GetSequence(5));
            
            // Assert (Check thte output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
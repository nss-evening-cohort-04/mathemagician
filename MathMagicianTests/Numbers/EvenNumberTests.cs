using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void EnsureICanCrestInstance()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you're testing)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void EnsureICanGetNext()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act
            int expectedResult = 8;
            int actualResult = evenNumber.GetNext(6);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            // Arrange
            EvenNumber EvenNumber = new EvenNumber();

            // Act
            int[] expectedResult = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int[] actualResult = EvenNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange
            EvenNumber EvenNumber = new EvenNumber();

            // Act
            string expectedResult = "2 4 6 8 10";
            int[] inputArray = new[] { 2, 4, 6, 8, 10 };
            string actualResult = EvenNumber.PrintNumbers(inputArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
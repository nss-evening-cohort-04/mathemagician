using System;
using MathMagician.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void EnsureEvenNumberIsNotNull()
        {
            EvenNumber evenNumber = new EvenNumber();
            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void CheckGetFirstEvenMethod()
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
        public void CheckEvenGetNextMethod()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(2);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckEvenGetSequenceMethod()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act
            int[] expectedResult = new int [] {2, 4, 6};
            int[] actualResult = evenNumber.GetSequence(3);

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckEvenPrintNumbersMethod()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act
            string expectedResult = "2 4 6";
            string actualResult = evenNumber.printNumbers(evenNumber.GetSequence(3));

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

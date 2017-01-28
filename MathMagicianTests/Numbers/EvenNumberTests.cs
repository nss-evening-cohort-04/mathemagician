using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void EnsureICanCreateEven()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }


        [TestMethod]
        public void EnsureTwoIsFirstNumber()
        {
            //Arrange (where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (call the method you're testing)
            int expectedResult = 2;
            int actualResult =  evenNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureFollowingEven()
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
        public void EnsureEvenSequence()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act 
            int[] expectedResult = new int[] { 2, 4, 6, 8, 10 };
            int[] actualResult = evenNumber.GetSequence(5);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintEvenSequence()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act
            string expectedResult = "2 4 6 8 10";
            int[] inputArray = new[] { 2, 4, 6, 8, 10 };
            string actualResult = evenNumber.PrintNumbers(inputArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

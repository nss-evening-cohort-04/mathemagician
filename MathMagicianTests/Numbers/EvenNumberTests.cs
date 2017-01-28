using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        // This is a sanity Check test.
        // Ensures everything is hooked up correctly AND
        // that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you're testing)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumberIsTwo()
        {
            // Arrange (Where you set stuff up
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you're testing)
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(evenNumber.GetFirst());

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            //Act
            int expectedResult = 8;
            int actualResult = evenNumber.GetNext(6);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureSequenceOfFive()
        {
            // Arrange (Where you set stuff up
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you're testing)
            int[] expectedResult = { 2, 4, 6, 8, 10 };
            int[] actualResult = evenNumber.GetSequence(5);

            // Assert (Check the output from your method)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureSequenceOfTwenty()
        {
            // Arrange (Where you set stuff up
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you're testing)
            int[] expectedResult = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 };
            int[] actualResult = evenNumber.GetSequence(20);

            // Assert (Check the output from your method)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumbersArePrinted()
        {
            //Arrange
            EvenNumber evenNumber = new EvenNumber();

            //Act
            string expectedResult = "2 4 6 8 10";
            int[] sequence = evenNumber.GetSequence(5);
            string actualResult = evenNumber.PrintNumbers(sequence);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

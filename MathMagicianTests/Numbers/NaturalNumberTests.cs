using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        // This is a sanity Check test.
        // Ensures everything is hooked up correctly AND
        // that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumberIsTwo()
        {
            // Arrange (Where you set stuff up
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int expectedResult = 2;
            int actualResult = naturalNumber.GetNext(1);

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            int expectedResult = 4;
            int actualResult = naturalNumber.GetNext(3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureSequenceOfFive()
        {
            // Arrange (Where you set stuff up
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int[] expectedResult = { 1, 2, 3, 4, 5 };
            int[] actualResult = naturalNumber.GetSequence(5);

            // Assert (Check the output from your method)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureSequenceOfTwenty()
        {
            // Arrange (Where you set stuff up
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] actualResult = naturalNumber.GetSequence(20);

            // Assert (Check the output from your method)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumbersArePrinted()
        {
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            string expectedResult = "1 2 3 4 5";
            string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

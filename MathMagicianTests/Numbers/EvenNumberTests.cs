using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;
using System.Diagnostics;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        // This is a sanity check test.
        // Ensures everything is hooked correctly and 
        // that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            // Act (Call the method you are testing)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            // Assert (check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
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
        public void EnsureNumberSequenceIsCorrect()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act
            int[] expectedResult = {0, 2, 4, 6, 8, 10 };
            int[] actualResult = evenNumber.GetSequence(10);

            // Assert
            // Collection.Assert looks at the values inside of the Array of ints
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureStringIsPrinted()
        {
            // Arrange
            EvenNumber evenNumber = new EvenNumber();

            // Act 
            string expectedResult = "2 4 6 8 10";
            string actualResult = evenNumber.PrintNumbers(new[] { 2, 4, 6, 8, 10 });

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}

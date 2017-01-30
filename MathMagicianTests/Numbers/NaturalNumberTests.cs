using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;
using System.Diagnostics;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        // This is a sanity check test.
        // Ensures everything is hooked correctly and 
        // that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturelNumber = new NaturalNumber();

            Assert.IsNotNull(naturelNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you are testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            // Assert (check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumberPassedPlusOne()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int expectedResult = 2;
            int numberPassed = 1;
            int actualResult = naturalNumber.GetNext(numberPassed);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNumberSequenceIsCorrect()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int[] expectedResult = { 1, 2, 3, 4, 5 };
            int numberPassed = 5;
            int[] actualResult = naturalNumber.GetSequence(numberPassed);
            
            // Assert
            // Collection.Assert looks at the values inside of the Array of ints
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureStringIsPrinter()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act 
            string expectedResult = "1 2 3 4 5 6 7 8 9 10";
            string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5, 6, 7, 8 , 9, 10 });

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}

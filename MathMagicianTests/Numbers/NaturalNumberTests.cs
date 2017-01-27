using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;
using System.Collections.Generic;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        // This is a sanity check test.
        // Ensures everything is hooked up correctly AND that the permissions are correct
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void CheckGetFirstMethod()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method you're testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void CheckGetNextMethod()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int expectedResult = 2;
            int actualResult = naturalNumber.GetNext(1);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckSequenceMethod()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int[] expectedResult = new int[] { 1, 2, 3 };
            int[] actualResult = naturalNumber.GetSequence(3);

            // Assert
            CollectionAssert.Equals(expectedResult, actualResult);

        }

        [TestMethod]
        public void CheckSequencePrintMethod()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            string expectedResult = "1, 2, 3";
            string actualResult = naturalNumber.printNumbers(naturalNumber.GetSequence(3));

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

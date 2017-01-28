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
            //Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (call the method you're testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureNextNumberIsCorrect()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int NextNumber = naturalNumber.GetNext(3);

            // Assert
            Assert.AreEqual(4, NextNumber);
        }

        [TestMethod]
        public void EnsureASequenceOfNumbers()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act 
            int[] SequenceOfNumbers = naturalNumber.GetSequence(5);
            int[] ExpectedSequence = new int[] { 1, 2, 3, 4, 5 };

            // Assert
            Assert.AreEqual(ExpectedSequence.Length, SequenceOfNumbers.Length);
            
        }
    }
}

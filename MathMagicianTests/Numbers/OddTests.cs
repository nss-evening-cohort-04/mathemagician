using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddTests
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            Odd odd = new Odd();
            Assert.IsNotNull(odd);
        }

        [TestMethod]
        public void EnsureOneIsFirstNumber()
        {
            //Arrange
            Odd odd = new Odd();

            //Act
            int expectedResult = 1;
            int actualResult = odd.GetFirst();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNextNumber()
        {
            //Arrange
            Odd odd = new Odd();

            //Act
            int expectedResult = 7;
            int actualResult = odd.GetNext(5);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanCreateSequence()
        {
            //Arrange
            Odd odd = new Odd();

            //Act
            int[] expectedResult = { 1, 3, 5, 7, 9, 11 };
            int[] actualResult = odd.GetSequence(6);

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            //Arrange
            Odd odd = new Odd();

            //Act
            string expectedResult = "1 3 5 7";
            int[] inputArray = { 1, 3, 5, 7 };
            string actualResult = odd.PrintNumbers(inputArray);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EnsureCanCreateInstance()
        {
            Even even = new Even();
            Assert.IsNotNull(even);
        }

        [TestMethod]
        public void EnsureFirstNumberIsTwo()
        {
            //Arrange
            Even even = new Even();

            //Act
            int expectedResult = 2;
            int actualResult = even.GetFirst();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCanGetNextNumber()
        {
            //Arrange
            Even even = new Even();

            //Act
            int expectedResult = 4;
            int actualResult = even.GetNext(2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCanCreateSequence()
        {
            //Arrange
            Even even = new Even();

            //Act
            int[] expectedResult = { 2, 4, 6, 8 };
            int[] actualResult = even.GetSequence(4);

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCanPrintSequence()
        {
            //Arrange
            Even even = new Even();

            //Act
            string expectedResult = "2 4 6";
            int[] inputArray = new[] { 2, 4, 6 };
            string actualResult = even.PrintNumbers(inputArray);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

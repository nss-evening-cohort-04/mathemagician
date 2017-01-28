using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        [TestMethod]
        public void EnsureICanCrestInstance()
        {
            EvenNumberWithInterface evenNumber = new EvenNumberWithInterface();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            EvenNumberWithInterface evenNumber = new EvenNumberWithInterface();

            // Act (Call the method you're testing)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            // Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void EnsureICanGetNext()
        {
            // Arrange
            EvenNumberWithInterface evenNumber = new EvenNumberWithInterface();

            // Act
            int expectedResult = 8;
            //int myNum; this is zero "0"
            int actualResult = evenNumber.GetNext(6);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        /*
        [TestMethod]
        public void EnsureICanGetSequence()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int myNum; this is zero "0"
            int[] actualResult = naturalNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            string expectedResult = "1 2 3 4 5";
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            string actualResult = naturalNumber.PrintNumbers(inputArray);
            //string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        */
    }
}

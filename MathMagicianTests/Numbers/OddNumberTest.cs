using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTest
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            OddNumber oddNumber = new OddNumber();
            Assert.IsNotNull(oddNumber);
        }


        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {

            //Arrange
            OddNumber oddNumber = new OddNumber();

            //Act(call the method you're testing)
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            //Assert(Check the output for your method)
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void EnsureICanGetNext()
        {
            //Arrange
            OddNumber oddNumber = new OddNumber();

            //Act
            int expectedResult = 5;
            int actualResult = oddNumber.GetNext(3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            //Arrange
            OddNumber oddNumber = new OddNumber();

            //Act
            int[] expectedResult = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] actualResult = oddNumber.GetSequence(10);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            //Arrange
            OddNumber oddNumber = new OddNumber();

            //Act
            string expectedResult = "1 3 5 7 9";
            int[] inputArray = new[] { 1, 3, 5, 7, 9 };
            string actualResult = oddNumber.PrintNumbers(inputArray);
            //string actualResult = oddNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

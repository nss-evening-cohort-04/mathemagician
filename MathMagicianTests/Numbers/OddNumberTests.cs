using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        [TestMethod]
        public void EnsureIcanCreateInstance()
        {
            OddNumber oddNumber = new OddNumber();
            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void GetFirstNumberTestMethod5()
        {
            //Arrange (Where you set stuff up)
            OddNumber oddNumber = new OddNumber();

            //Act (Where you call the method you are testing aka 'GetFirst()' for this example)
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void GetNextTestMethod()
        {
            //arrange 
            OddNumber oddNumber = new OddNumber();

            //act
            int expectedResult = 3 + 2;
            int actualResult = oddNumber.GetNext(3);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetSequence()
        {
            //arrange
            OddNumber oddNumber = new OddNumber();

            //act
            int[] expectedResult = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] actualResult = oddNumber.GetSequence(10);

            //assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Printumberz()
        {
            //arrange
            OddNumber oddNumber = new OddNumber();

            //act
            string expectedResult = "1 3 5 7 9";
            string actualResult = oddNumber.PrintNumbers(oddNumber.GetSequence(5));


            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
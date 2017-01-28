using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
         //This is a sanity check
         //Ensures everything is hooked up correctly AND
         //that the parameters are correct
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            //Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you are testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureTwoIsTheNextNumber()
        {
            //Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you are testing)
            int expectedResult = 2;
            int actualResult = naturalNumber.GetNext(1);

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCorrectSequenceIsReturned()
        {
            //Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you are testing)
            int[] expectedResult = { 1, 2, 3 };
            int[] actualResult = naturalNumber.GetSequence(3);

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void ENsureICanPrintSequence()
        {
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            string expectedResult = "1 2 3 4 5";
            string actualResult = naturalNumber.PrintNumbers(new int[] { 1, 2, 3, 4, 5 });
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

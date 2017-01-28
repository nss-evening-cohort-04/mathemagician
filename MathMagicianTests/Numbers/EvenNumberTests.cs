using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        //This is a sanity check
        //Ensures everything is hooked up correctly AND
        //that the parameters are correct
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirst()
        {
            //Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (Call the method you are testing)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureFourIsTheNextNumber()
        {
            //Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (Call the method you are testing)
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(2);

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCorrectSequenceIsReturned()
        {
            //Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (Call the method you are testing)
            int[] expectedResult = { 2, 4 };
            int[] actualResult = evenNumber.GetSequence(2);

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

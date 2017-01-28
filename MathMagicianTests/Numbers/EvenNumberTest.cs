using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTest
    {
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber evenNumber = new EvenNumber();
            Assert.IsNotNull(evenNumber);
        }


        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {

            //Arrange
            EvenNumber evenNumber = new EvenNumber();

            //Act(call the method you're testing)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            //Assert(Check the output for your method)
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void EnsureICanGetNext()
        {
            //Arrange
            EvenNumber evenNumber = new EvenNumber();

            //Act
            int expectedResult = 4;
            int actualResult = evenNumber.GetNext(2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            //Arrange
            EvenNumber evenNumber = new EvenNumber();

            //Act
            int[] expectedResult = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
            int[] actualResult = evenNumber.GetSequence(10);

            //Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanPrintSequence()
        {
            //Arrange
            EvenNumber evenNumber = new EvenNumber();

            //Act
            string expectedResult = "2 4 6 8 10";
            int[] inputArray = new[] { 2, 4, 6, 8, 10 };
            string actualResult = evenNumber.PrintNumbers(inputArray);
            //string actualResult = evenNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

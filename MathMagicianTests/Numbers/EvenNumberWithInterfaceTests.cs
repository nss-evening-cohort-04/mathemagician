using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;


namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberWithInterfaceTests
    {
        //**This is a sanity test example. It ensures everything is hooked up correctly
        //** AND that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance2()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void GetFirstNumberTestMethod2()
        {
            //Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (Where you call the method you are testing aka 'GetFirst()' for this example)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void GetNextTestMethod()
        {
            //arrange 
            EvenNumber evenNumber = new EvenNumber();

            //act
            int expectedResult = 2 + 2;
            int actualResult = evenNumber.GetNext(2);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetSequence()
        {
            //arrange
            EvenNumber evenNumber = new EvenNumber();

            //act
            int[] expectedResult = { 2, 4, 6, 8, 10 };
            int[] actualResult = evenNumber.GetSequence(5);

            //assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Printumberz()
        {
            //arrange
            EvenNumber evenNumber = new EvenNumber();

            //act
            string expectedResult = "2 4 6 8 10";
            int[] inputArray = new[] { 2, 4, 6, 8, 10 };
            string actualResult = evenNumber.PrintNumbers(inputArray);
            //string actualResult = evenNumber.PrintNumbers(new [] { 2, 4, 6, 8, 10 }); aother way of doing things

            //assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

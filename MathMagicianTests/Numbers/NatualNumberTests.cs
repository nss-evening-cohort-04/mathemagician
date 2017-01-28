using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NatualNumberTests
    {
        //**This is a sanity test example. It ensures everything is hooked up correctly
        //** AND that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance() 
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void GetFirstNumberTestMethod()
        {
            //Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Where you call the method you are testing aka 'GetFirst()' for this example)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void GetNextTestMethod()
        {
            //arrange 
            NaturalNumber naturalNumber = new NaturalNumber();

            //act
            int expectedResult = 4;
            int actualResult = naturalNumber.GetNext(3);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetSequence()
        {
            //arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //act
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actualResult = naturalNumber.GetSequence(10);

            //assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Printumberz()
        {
            //arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //act
            string expectedResult = "1 2 3 4 5";
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            string actualResult = naturalNumber.PrintNumbers(inputArray);
            //string actualResult = naturalNumber.PrintNumbers(new [] { 1, 2, 3, 4, 5 }); aother way of doing things

            //assert
            Assert.AreEqual(expectedResult, actualResult);
            
        }
    }
}

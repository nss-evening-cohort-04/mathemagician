using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class FibonacciNumberTests
    {
        //This is a sanity check
        //Ensures everything is hooked up correctly AND
        //that the parameters are correct
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            FibonacciNumber fibNumber = new FibonacciNumber();

            Assert.IsNotNull(fibNumber);
        }

        [TestMethod]
        public void EnsureZeroIsTheFirst()
        {
            //Arrange (Where you set stuff up)
            FibonacciNumber fibNumber = new FibonacciNumber();

            //Act (Call the method you are testing)
            int expectedResult = 0;
            int actualResult = fibNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCorrectSequenceIsReturned()
        {
            //Arrange (Where you set stuff up)
            FibonacciNumber fibNumber = new FibonacciNumber();

            //Act (Call the method you are testing)
            int[] expectedResult = { 0,1,1,2,3,5,8,13 };
            int[] actualResult = fibNumber.GetSequence(8);

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

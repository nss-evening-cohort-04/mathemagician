using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        //This a sanity check test.
        //Ensures everything is hooked up correctly and
        //that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            //int GetFirst();
            //Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you're testing) test one method at the time.
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (Check the output from your method.)
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureGetNext()
        {
            //int GetNext(int current);
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            int expectedResult = 1;
            int actualResult = naturalNumber.GetNext(20);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsureGetSequence()
        {
            //int[] GetSequence(int how_many);
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            int[] expectedResult = new int[] { 10,15,20 };
            int[] actualResult = naturalNumber.GetSequence(10);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void EnsurePrintNumbers()
        {
            //string PrintNumbers(int[] how_many);
            //Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act
            int[] expectedResult = new int[] { 10, 20, 30 };
            //int[] actualResult = naturalNumber.PrintNumbers(10);

            //Assert
            //Assert.AreEqual(expectedResult, actualResult);
        }
    }
}



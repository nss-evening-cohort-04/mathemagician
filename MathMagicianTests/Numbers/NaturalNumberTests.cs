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
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void EnsureGetSequence()
        {
            //Arrange

            //Act

            //Assert
        }
        [TestMethod]
        public void EnsurePrintNumbers()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
//int GetNext(int current);
//int[] GetSequence(int how_many);
//string PrintNumbers(int[] how_many);

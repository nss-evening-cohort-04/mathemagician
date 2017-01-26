using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        //this is a sanity check test
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
            //Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, expectedResult);

        }

        [TestMethod]
        public void EnsureGetNextReturnsCurrentPlusOne()
        {
            //Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int expectedResult = 11;
            int actualResult = naturalNumber.GetNext(10);
            

            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void EnsureGetSequenceReturnsIntArray()
        {
            //Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int[] actualResult = naturalNumber.GetSequence(10);


            //Assert (check the output from your method)
            Assert.IsInstanceOfType(actualResult, typeof(int[]));
        }

        [TestMethod]
        public void EnsurePrintNumbersReturnString()
        {
            //Arrange (where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int[] sequenceArray = naturalNumber.GetSequence(10);
            string actualResult = naturalNumber.PrintNumbers(sequenceArray);


            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, "Here Ya Go: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11");
        }
    }
}

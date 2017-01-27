using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathMagician.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        //this is a sanity check test
        //Ensures everything is hooked up correctly and
        //that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateOddNumberInstance()
        {
            OddNumber oddNumber = new OddNumber();

            Assert.IsNotNull(oddNumber);
        }

        [TestMethod]
        public void CheckFirstOddNumber()
        {
            //Arrange (where you set stuff up)
            OddNumber oddNumber = new OddNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int expectedResult = 1;
            int actualResult = oddNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void GetNextReturnsNextOddNumber()
        {
            //Arrange (where you set stuff up)
            OddNumber oddNumber = new OddNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int expectedResult = 12;
            int actualResult = oddNumber.GetNext(10);


            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void GetSequenceReturnsIntArray()
        {
            //Arrange (where you set stuff up)
            OddNumber oddNumber = new OddNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int[] actualResult = oddNumber.GetSequence(10);


            //Assert (check the output from your method)
            Assert.IsInstanceOfType(actualResult, typeof(int[]));
        }

        [TestMethod]
        public void PrintNumberReturnCorrectString()
        {
            //Arrange (where you set stuff up)
            OddNumber oddNumber = new OddNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int[] sequenceArray = oddNumber.GetSequence(10);
            string actualResult = oddNumber.PrintNumbers(sequenceArray);


            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, "Here Ya Go: 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21");

        }
    }
}

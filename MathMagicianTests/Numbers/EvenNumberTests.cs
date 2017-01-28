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
    public class EvenNumberTests
    {
        //this is a sanity check test
        //Ensures everything is hooked up correctly and
        //that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateOddNumberInstance()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void CheckFirstEvenNumber()
        {
            //Arrange (where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void GetNextReturnsNextEvenNumber()
        {
            //Arrange (where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int expectedResult = 12;
            int actualResult = evenNumber.GetNext(10);


            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void EvenGetSequenceReturnsIntArray()
        {
            //Arrange (where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int[] actualResult = evenNumber.GetSequence(10);


            //Assert (check the output from your method)
            Assert.IsInstanceOfType(actualResult, typeof(int[]));
        }

        [TestMethod]
        public void PrintNumberReturnCorrectString()
        {
            //Arrange (where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (call the method you're testing)
            //test only one method at a time
            int[] sequenceArray = evenNumber.GetSequence(10);
            string actualResult = evenNumber.PrintNumbers(sequenceArray);


            //Assert (check the output from your method)
            Assert.AreEqual(actualResult, "Here Ya Go: 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22");

        }
    }

}

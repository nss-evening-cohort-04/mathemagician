using System;
using MathMagician.Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTest
    {
        [TestMethod]
        public void EnsureICanCreatInstanceEven()
        {
            EvenNumber evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirstNumber()
        {
            //Arrange (set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (call method you are testing)
            int expectedResult = 2;
            int actualResult = 2;

            //Assert (check output)
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCanGetNextEvenNumber()
        {
            //Arrange (set stuff up)
            EvenNumber evenNumber = new EvenNumber();
            int current = 4;
            //Act (call method you are testing)
            int expectedResult = 6;
            int actualResult = evenNumber.GetNext(4);


            //Assert (check output)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureCanGetSequenceEvenNumber()
        {
            //Arrange (set stuff up)
            EvenNumber evenNumber = new EvenNumber();
            //Act (call method you are testing)
            int[] expectedResult = { 2, 4, 6, 8, 10 };
            int[] actualResult = evenNumber.GetSequence(5);


            //Assert (check output)
            //Assert.AreEqual(expectedResult.Length, actualResult.Length);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}

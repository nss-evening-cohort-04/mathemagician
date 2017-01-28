using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTest
    {
        [TestMethod]
        public void EnsureICanCreatInstance()
        {
            NaturalNumbers naturalNumber = new NaturalNumbers();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            //Arrange (set stuff up)
            NaturalNumbers naturalNumber = new NaturalNumbers();

            //Act (call method you are testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();


            //Assert (check output)
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void EnsureCanGetNextNumber()
        {
            //Arrange (set stuff up)
            NaturalNumbers naturalNumber = new NaturalNumbers();
            int current = 3;
            //Act (call method you are testing)
            int expectedResult = 4;
            int actualResult = naturalNumber.GetNext(current);


            //Assert (check output)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureCanGetSequenceOfNumbers()
        {
            //Arrange (set stuff up)
            NaturalNumbers naturalNumber = new NaturalNumbers();
            int []how_many = { 1, 2, 3, 4 };
            //Act (call method you are testing)
            int[] expectedResult = { 1, 2, 3, 4 };
            int[] actualResult = naturalNumber.GetSequence(3);


            //Assert (check output)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}

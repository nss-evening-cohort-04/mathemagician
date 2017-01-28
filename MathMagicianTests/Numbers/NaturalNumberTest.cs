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
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actualResult = naturalNumber.GetSequence(10);


            //Assert (check output)
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureCanPrintNumbers()
        {
            //Arrange (set stuff up)
            NaturalNumbers naturalNumber = new NaturalNumbers();
            
            //Act (call method you are testing)
            string expectedResult = "1, 2, 3, 4, 5";
            int[] inputArray = new[] { 1,2,3,4,5 };
            string actualResult = naturalNumber.printNumbers(inputArray);


            //Assert (check output)
            Assert.AreEqual(expectedResult, actualResult);

            }
        }
}

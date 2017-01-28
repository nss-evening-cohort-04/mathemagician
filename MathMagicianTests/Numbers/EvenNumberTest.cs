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
            int actualResult = evenNumber.GetFirst();


            //Assert (check output)
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

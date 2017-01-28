using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTest
    {
        [TestMethod]
        public void EnsureICanCreatInstance()
        {
            EvenNumber naturalNumber = new EvenNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureTwoIsTheFirstNumber()
        {
            //Arrange (set stuff up)
            NaturalNumbers naturalNumber = new EvenNumber();

            //Act (call method you are testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();


            //Assert (check output)
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

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
    }
}

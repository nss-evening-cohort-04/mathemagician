using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
         //This is a sanity check
         //Ensures everything is hooked up correctly AND
         //that the parameters are correct
        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirst()
        {
            //Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Call the method you are testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

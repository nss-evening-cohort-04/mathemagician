using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NatualNumberTests
    {
        //**This is a sanity test example. It ensures everything is hooked up correctly
        //** AND that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance() 
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void GetFirstNumberTestMethod()
        {
            //Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            //Act (Where you call the method you are testing aka 'GetFirst()' for this example)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);


        }
    }
}

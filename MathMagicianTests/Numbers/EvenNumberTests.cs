using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenNumberTests
    {
        //**This is a sanity test example. It ensures everything is hooked up correctly
        //** AND that the permissions are correct.
        [TestMethod]
        public void EnsureICanCreateInstance2()
        {
            EvenNumberTests evenNumber = new EvenNumber();

            Assert.IsNotNull(evenNumber);
        }

        [TestMethod]
        public void GetFirstNumberTestMethod2()
        {
            //Arrange (Where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (Where you call the method you are testing aka 'GetFirst()' for this example)
            int expectedResult = 2;
            int actualResult = evenNumber.GetFirst();

            //Assert (Check the output from your method)
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

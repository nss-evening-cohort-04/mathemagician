using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class EvenTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            EvenNumber naturalNumber = new NaturalNumber();
            Assert.IsNotNull(naturalNumber);
        }
    }
}

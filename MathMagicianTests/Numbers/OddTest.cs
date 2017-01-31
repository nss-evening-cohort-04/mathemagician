
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;

namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class OddNumberTests
    {
        
        [TestMethod]
        public void EnsureICanCreateInstanceOdd()
        {
            OddNumber oddNumber = new OddNumber();
            Assert.IsNotNull(oddNumber);
        }

       
    }
}
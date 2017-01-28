using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;
using System.Diagnostics;

namespace MathMagicianTests.EvenNumbers
{
    public class EvenNumberTests
    {
        
        [TestMethod]
        public void EvenNumbers()
        {
            //Arrange (where you set stuff up)
            EvenNumber evenNumber = new EvenNumber();

            //Act (Call the method you are testing)
            int result = 2;
            int actualresult = evenNumber.GetFirst();

            //Assert (check the output from your method)
            Assert.AreEqual(result, actualresult);
        }
    }
  }


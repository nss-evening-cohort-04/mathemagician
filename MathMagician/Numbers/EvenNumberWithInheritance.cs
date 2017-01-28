﻿using MathMagician.Numbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    class EvenNumberWithInheritance : NaturalNumber
    {
        public EvenNumberWithInheritance()
        {
            First = 2;
            Step = 2;
        }
        public override int GetNext(int current)
        {
            return current + 2;
        }
    }
}

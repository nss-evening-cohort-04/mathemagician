﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//THIS IS INHERITED FROM NATURALNUMBER

namespace MathMagician.Numbers
{
    public class Odd : NaturalNumber
    {
        public Odd()
        {
            First = 1;
            Step = 2;
        }
    }
}

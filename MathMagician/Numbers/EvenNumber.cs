﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician.Numbers
{
    public class EvenNumber : NaturalNumber
    {
        //don't want them to access it outside of the class//
        public EvenNumber()
        {
            FirstNumber = 2;
            Step = 2;
        }
    }
}

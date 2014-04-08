﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.BinaryCalculators
{
    public class Log : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            double result = Math.Log(firstArgument,secondArgument);
            return result;
        }
    }
}

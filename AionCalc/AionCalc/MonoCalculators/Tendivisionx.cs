using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Tendivisionx : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            double result = 10 / firstArgument;
            return result;
        }
    }
}

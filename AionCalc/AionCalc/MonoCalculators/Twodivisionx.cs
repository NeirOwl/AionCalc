using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Twodivisionx : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            double result = 2 / firstArgument;
            return result;
        }
    }
}

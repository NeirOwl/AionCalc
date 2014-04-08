using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Sqrtpow3x : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Pow(firstArgument,(double)1/3);
            return result;
        }
    }
}

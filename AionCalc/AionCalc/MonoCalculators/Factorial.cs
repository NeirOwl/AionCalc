using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Factorial : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            double result = 0;
            double factorial = 0;
            for (int i = 1; i < firstArgument; i++)
            {
                factorial = firstArgument*i;
            }
            result = factorial;
            return result;
        }
    }
}

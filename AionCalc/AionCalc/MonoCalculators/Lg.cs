using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Lg : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Log10(firstArgument);
            return result;
        }
    }
}

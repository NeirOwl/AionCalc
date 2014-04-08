using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Cos : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Cos(firstArgument);
            return result;
        }
    }
}

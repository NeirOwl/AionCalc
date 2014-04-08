using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Tanh : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Tanh(firstArgument);
            return result;
        }
    }
}

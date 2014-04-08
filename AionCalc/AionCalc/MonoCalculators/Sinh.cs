using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Sinh : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            double result = Math.Sinh(firstArgument);
            return result;
        }
    }
}
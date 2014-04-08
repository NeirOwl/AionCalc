using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Gradtorad : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            double result = firstArgument * Math.PI / 180;
            return result;
        }
    }
}

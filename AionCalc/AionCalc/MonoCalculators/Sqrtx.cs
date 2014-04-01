using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Sqrtx : IMonoCalculator
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Sqrt(firstArgument);
            return result.ToString();
        }
    }
}

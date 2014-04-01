using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Exppowx : IMonoCalculator
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Exp(firstArgument);
            return result.ToString();
        }
    }
}

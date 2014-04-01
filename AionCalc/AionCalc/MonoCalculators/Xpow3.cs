using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Xpow3 : IMonoCalculator
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Pow(firstArgument,3);
            return result.ToString();
        }
    }
}

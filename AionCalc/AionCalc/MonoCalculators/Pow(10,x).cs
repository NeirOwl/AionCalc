using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Pow_10_x_ : IMonoCalculator
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Pow(10,firstArgument);
            return result.ToString();
        }
    }
}
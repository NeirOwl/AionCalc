using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Tan : IMonoCalculator
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Tan(firstArgument);
            return result.ToString();
        }
    }
}
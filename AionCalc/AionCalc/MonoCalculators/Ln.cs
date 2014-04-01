using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Ln : IMonoCalculator
    {
        public string Calculate(double firstArgument)
        {
            double result = Math.Log(firstArgument,Math.Exp(1));
            return result.ToString();
        }
    }
}

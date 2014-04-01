using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Tenmultiplyx : IMonoCalculator
    {
        public string Calculate(double firstArgument)
        {
            double result = 10 * firstArgument;
            return result.ToString();
        }
    }
}

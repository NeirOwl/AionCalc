using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Sqrtx : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Корень из отрицательного числа невозможен");
            }
            double result = Math.Sqrt(firstArgument);
            return result;
        }
    }
}

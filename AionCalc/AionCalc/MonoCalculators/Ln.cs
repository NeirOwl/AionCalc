using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public class Ln : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Логарифм отрицательного числа не существует");
            }
            double result = Math.Log(firstArgument,Math.Exp(1));
            return result;
        }
    }
}

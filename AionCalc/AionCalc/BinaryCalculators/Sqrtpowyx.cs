using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.BinaryCalculators
{
    public class Sqrtpowyx : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < 0 )
            {
                throw new Exception("Корень из отрицательного числа невозможен");
            }
            double result = Math.Pow(firstArgument,1/secondArgument);
            return result;
        }
    }
}

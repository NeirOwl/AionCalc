using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.BinaryCalculators
{
    public class Tenmultiplyxdivisiony : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0 невозможно");
            }
            double result = 10 * firstArgument / secondArgument;
            return result;
        }
    }
}

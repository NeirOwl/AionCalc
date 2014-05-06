using System;

namespace AionCalc.BinaryCalculators
{
    public class Twomultiplyxdivisiony : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0 невозможно");
            }
            double result = 2 * firstArgument / secondArgument;
            return result;
        }
    }
}

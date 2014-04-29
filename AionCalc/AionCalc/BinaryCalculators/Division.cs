using System;

namespace AionCalc.BinaryCalculators
{
    public class Division : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0 невозможно");
            }
            double result = firstArgument / secondArgument;
            return result;
        }
    }
}

using System;

namespace AionCalc.BinaryCalculators
{
    public class Ydevisionx : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Деление на 0 невозможно");
            }
            double result = secondArgument / firstArgument;
            return result;
        }
    }
}

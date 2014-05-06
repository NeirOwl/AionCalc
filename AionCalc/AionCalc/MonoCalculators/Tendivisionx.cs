using System;

namespace AionCalc.MonoCalculators
{
    public class Tendivisionx : IMonoCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Деление на 0 невозможно");
            }
            double result = 10 / firstArgument;
            return result;
        }
    }
}

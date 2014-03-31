using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.MonoCalculators
{
    public static class MonoOperationsFactory
    {
        public static IMonoCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "cos":
                    return new Cos();
                case "sin":
                    return new Sin();
                case "tanh":
                    return new Tanh();
                case "^_10_x_":
                    return new Pow_10_x_();
                case "*_10_x_":
                    return new Multiplication_10_x_();
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }
        }
    }
}

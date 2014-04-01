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
                case "10^x":
                    return new Tenpowerx();
                case "10*x":
                    return new Tenmultiplyx();
                case "sqrtx":
                    return new Sqrtx();
                case "gradtorad":
                    return new Gradtorad();
                case "tan":
                    return new Tan();
                case "e^x":
                    return new Exppowx();
                case "2/x":
                    return new Twodivisionx();
                case "sqrtpow3x":
                    return new Sqrtpow3x();
                case "x!":
                    return new Factorial();
                case "10/x":
                    return new Tendivisionx();
                case "x^3":
                    return new Xpow3();
                case "sinh":
                    return new Sinh();
                case "cosh":
                    return new Cosh();
                case "lg":
                    return new Lg();
                case "ln":
                    return new Ln();
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }
        }
    }
}

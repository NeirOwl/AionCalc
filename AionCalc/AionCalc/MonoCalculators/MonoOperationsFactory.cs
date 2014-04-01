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
                    return  new Sqrtx();
                case "gradtorad":
                    return  new Gradtorad();
                case "tan":
                    return  new Tan();
                case "exppowx":
                    return  new Exppowx();
                case "twodivisionx":
                    return  new Twodivisionx();
                case "sqrtpow3x":
                    return  new Sqrtpow3x();
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }
        }
    }
}

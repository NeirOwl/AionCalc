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
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }
        }
    }
}

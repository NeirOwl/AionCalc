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
                default:
                    throw new ArgumentException("Неизвестный калькулятор", "name");
            }
        }
    }
}

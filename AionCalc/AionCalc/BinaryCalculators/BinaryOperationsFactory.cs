using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.BinaryCalculators
{
    public static class BinaryOperationsFactory
    {
        public static IBinaryCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "+": 
                    return new Adder();
                case "-":
                    return new Subtraction();
                case "/":
                    return new Division();
                case "*":
                    return new Multiplication();
                case "y/x":
                    return new Ydevisionx();
                default: 
                    throw new ArgumentException("Неизвестный калькулятор","name");
            }
        }
    }
}

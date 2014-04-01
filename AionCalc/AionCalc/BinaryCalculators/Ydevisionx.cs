using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.BinaryCalculators
{
    public class Ydevisionx : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = secondArgument / firstArgument;
            return result.ToString();
        }
    }
}

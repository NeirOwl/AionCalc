using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.BinaryCalculators
{
    public class Division_y_x_ : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = secondArgument / firstArgument;
            return result.ToString();
        }
    }
}

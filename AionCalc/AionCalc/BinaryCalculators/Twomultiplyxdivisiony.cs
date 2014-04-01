using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.BinaryCalculators
{
    public class Twomultiplyxdivisiony : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = 2 * firstArgument / secondArgument;
            return result.ToString();
        }
    }
}

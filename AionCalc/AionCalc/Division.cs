using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc
{
    public class Division
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument;
            return result.ToString();
        }
    }
}

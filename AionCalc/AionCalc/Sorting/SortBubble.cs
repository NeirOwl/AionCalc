using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.Sorting
{
    public class SortBubble : ISortingOperation
    {
        public int[] SortMass(int[] firstArgument)
        {
            int temp;
            for (int i = 0; i < firstArgument.Length - 1; i++)
            {
                for (int j = 0; j < firstArgument.Length - i - 1; j++)
                {
                    if (firstArgument[j] > firstArgument[j + 1])
                    {
                        temp = firstArgument[j];
                        firstArgument[j] = firstArgument[j + 1];
                        firstArgument[j + 1] = temp;
                    }
                }
            }
            return firstArgument;
        }
    }
}

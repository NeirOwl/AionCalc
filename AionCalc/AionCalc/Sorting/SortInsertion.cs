using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.Sorting
{
    public class SortInsertion : ISortingOperation
    {
        public int[] SortMass(int[] firtsArgument)
        {
            for (int i = 1; i < firtsArgument.Length; i++)
            {
                int currElem = firtsArgument[i];
                int prevKey = i - 1;
                while (prevKey >= 0 && firtsArgument[prevKey] > currElem)
                {
                    firtsArgument[prevKey + 1] = firtsArgument[prevKey];
                    firtsArgument[prevKey] = currElem;
                    prevKey--;
                }
            }
            return firtsArgument;
        }
    }
}

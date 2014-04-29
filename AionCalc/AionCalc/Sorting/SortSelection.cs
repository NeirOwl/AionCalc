using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.Sorting
{
    public class SortSelection : ISortingOperation
    {
       public int[] SortMass(int[] firstAgrument)
        {
            for (int i = 0; i < firstAgrument.Length-1; i++)
            {
                int min = i;
                for (int j = i + 1; j < firstAgrument.Length; j++)
                {
                    if (firstAgrument[j] < firstAgrument[min])
                    {
                        min = j;
                    }
                }
                int dummy = firstAgrument[i];
                firstAgrument[i] = firstAgrument[min];
                firstAgrument[min] = dummy;
            }
            return firstAgrument;
        }
    }
}

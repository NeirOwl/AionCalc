using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.Sorting
{
    public class SortCocktail : ISortingOperation
    {
        public int[] SortMass(int[] firtsArgument)
        {
            int beg, end;
            int count = 0;
            for (int i = 0; i < firtsArgument.Length/2; i++)
            {                                        
                beg = 0;
                end = firtsArgument.Length - 1;
                do
                {
                    count += 2;
                    if (firtsArgument[beg] > firtsArgument[beg + 1]) 
                        Swap(firtsArgument,beg,beg+1);    
                    beg++; 
                    if (firtsArgument[end-1] > firtsArgument[end]) 
                        Swap(firtsArgument, end - 1, end);
                    end--;
 
                }
                while (beg <= end);
             }
            return firtsArgument;
        }
        private void Swap(int[] firstArgument, int i, int j)
        {
            int glass;
            glass = firstArgument[i];
            firstArgument[i] = firstArgument[j];
            firstArgument[j] = glass;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AionCalc.Sorting
{
    public static class SortingOperationFactory
    {
        public static ISortingOperation CreateSorting(string name)
        {
            switch (name)
            {
                case "Sort":
                    return new Sort();
                default:
                    throw new ArgumentException("Unknown calculator", "name");
            }
        }
    }
}

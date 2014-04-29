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
                case "SortBubble":
                    return new SortBubble();
                case "SortSelection":
                    return new SortSelection();
                case "SortInsertion":
                    return new SortInsertion();
                case "SortCocktail":
                    return new SortCocktail();
                default:
                    throw new ArgumentException("Unknown calculator", "name");
            }
        }
    }
}

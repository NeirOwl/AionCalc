using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AionCalc.Sorting;
using NUnit.Framework;

namespace AionCalc.Tests.Sorting
{
    [TestFixture]
    public class SortInsertion
    {
        [Test]
        public void SortInsertionTest()
        {
            ISortingOperation sorter = SortingOperationFactory.CreateSorting("SortInsertion");
            int[] a = new int[] {5, 4, 3, 2, 1};
            int[] b = new int[] {1, 2, 3, 4, 5};
            int[] result = sorter.SortMass(a);
            Assert.AreEqual(b, result);
        }
    }
}

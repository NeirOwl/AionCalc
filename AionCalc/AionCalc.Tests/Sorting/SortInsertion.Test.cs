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
            int[] source = { 5, 4, 3, 2, 1 };
            int[] expexted = { 1, 2, 3, 4, 5 };
            int[] result = sorter.SortMass(source);
            Assert.AreEqual(expexted.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expexted[i], result[i]);
            }
        }

        [Test]
        public void SortNegetiveValuesTest()
        {
            ISortingOperation sorter = SortingOperationFactory.CreateSorting("SortInsertion");
            int[] source = { -6, 3, -1, 1, -8 };
            int[] expexted = { -8, -6, -1, 1, 3 };
            int[] result = sorter.SortMass(source);
            Assert.AreEqual(expexted.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expexted[i], result[i]);
            }
        }

        [Test]
        public void SortReValuesTest()
        {
            ISortingOperation sorter = SortingOperationFactory.CreateSorting("SortInsertion");
            int[] source = { -1, 4, 8, 8, -2 };
            int[] expexted = { -2, -1, 4, 8, 8 };
            int[] result = sorter.SortMass(source);
            Assert.AreEqual(expexted.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expexted[i], result[i]);
            }
        }
    }
}
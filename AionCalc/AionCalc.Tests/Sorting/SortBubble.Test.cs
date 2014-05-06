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
    public class SortBubble
    {
        [Test]
        public void SortBubbleTest()
        {
            ISortingOperation sorter = SortingOperationFactory.CreateSorting("SortBubble");
            int[] source = { 5, 4, 3, 2, 1 };
            int[] expexted = { 1, 2, 3, 4, 5 };
            int[] result = sorter.SortMass(source);
            Assert.AreEqual(expexted.Length, result.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expexted[i], result[i]);
            }
        }
    }
}

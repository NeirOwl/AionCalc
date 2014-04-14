using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AionCalc.BinaryCalculators;
using NUnit.Framework;

namespace AionCalc.Tests.BinaryCalculators
{
    [TestFixture]
    public class Xpowy
    {
        [Test]
        public void XpowyTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("x^y");
            double result = calc.Calculate(3, 3);
            Assert.AreEqual(27, result);
        }
    }
}
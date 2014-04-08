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
    public class Multiplication
    {
        [Test]
        public void MultiTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("*");
            double result = calc.Calculate(3, 3);
            Assert.AreEqual(9, result);
        }
    }
}
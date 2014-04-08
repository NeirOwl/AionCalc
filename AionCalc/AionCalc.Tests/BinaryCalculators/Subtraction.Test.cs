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
    public class Subtraction
    {
        [Test]
        public void SubTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("-");
            double result = calc.Calculate(10, 3);
            Assert.AreEqual(7, result);
        }
    }
}

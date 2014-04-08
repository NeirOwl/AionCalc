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
    public class Division
    {
        [Test]
        public void DivTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("/");
            double result = calc.Calculate(6, 3);
            Assert.AreEqual(2, result);
        }
    }
}

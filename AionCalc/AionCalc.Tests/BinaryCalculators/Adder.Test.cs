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
    public class Adder
    {
        [Test]
        public void AddTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("+");
            double result = calc.Calculate(2, 3);
            Assert.AreEqual(5,result);
        }
    }
}

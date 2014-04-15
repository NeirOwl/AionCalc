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
    public class Log
    {
        [Test]
        public void LogTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("log");
            double result = calc.Calculate(3, 4);
            Assert.AreEqual(0.79, result, 0.01);
        }
    }
}

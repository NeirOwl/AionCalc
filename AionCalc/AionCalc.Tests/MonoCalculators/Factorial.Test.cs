using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AionCalc.MonoCalculators;
using NUnit.Framework;

namespace AionCalc.Tests.MonoCalculators
{
    [TestFixture]
    public class Factorial
    {
        [Test]
        public void FactorialTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("x!");
            double result = calc.Calculate(5);
            Assert.AreEqual(20, result);
        }
    }
}

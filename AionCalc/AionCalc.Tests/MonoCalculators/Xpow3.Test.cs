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
    public class Xpow3
    {
        [Test]
        public void Xpow3Test()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("x^3");
            double result = calc.Calculate(3);
            Assert.AreEqual(27, result);
        }
    }
}

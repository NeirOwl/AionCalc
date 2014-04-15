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
    public class Sqrtpow3x
    {
        [Test]
        public void Sqrtpow3xTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("sqrtpow3x");
            double result = calc.Calculate(8);
            Assert.AreEqual(2, result);
        }
    }
}
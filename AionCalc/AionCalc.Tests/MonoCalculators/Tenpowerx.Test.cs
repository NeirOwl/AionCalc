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
    public class Tenpowerx
    {
        [Test]
        public void TenpowerxTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("10^x");
            double result = calc.Calculate(2);
            Assert.AreEqual(100, result);
        }
    }
}
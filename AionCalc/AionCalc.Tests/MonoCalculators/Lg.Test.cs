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
    public class Lg
    {
        [Test]
        public void LgTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("lg");
            double result = calc.Calculate(3);
            Assert.AreEqual(0.47, result, 0.01);
        }
    }
}

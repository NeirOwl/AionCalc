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
    public class Exppowx
    {
        [Test]
        public void ExppowxTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("e^x");
            double result = calc.Calculate(2);
            Assert.AreEqual(7.38, result, 0.01);
        }
    }
}

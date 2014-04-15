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
    public class Tendivisionx
    {
        [Test]
        public void TendivisionxTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("10/x");
            double result = calc.Calculate(5);
            Assert.AreEqual(2, result);
        }
    }
}

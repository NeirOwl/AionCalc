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
    public class Ln
    {
        [Test]
        public void LnTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("ln");
            double result = calc.Calculate(2);
            Assert.AreEqual(0.69, result, 0.01);
        }
    }
}
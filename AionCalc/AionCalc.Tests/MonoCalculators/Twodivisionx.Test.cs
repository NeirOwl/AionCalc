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
    public class Twodivisionx
    {
        [Test]
        public void TwodivisionxTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("2/x");
            double result = calc.Calculate(4);
            Assert.AreEqual(0.5, result);
        }
    }
}
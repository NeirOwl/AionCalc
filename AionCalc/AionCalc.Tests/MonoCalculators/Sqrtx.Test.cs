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
    public class Sqrtx
    {
        [Test]
        public void AddTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("sqrtx");
            double result = calc.Calculate(4);
            Assert.AreEqual(2, result);
        }
    }
}

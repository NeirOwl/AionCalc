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
    public class Tan
    {
        [Test]
        public void TanTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("tan");
            double result = calc.Calculate(1);
            Assert.AreEqual(1.55, result, 0.008);
        }
    }
}
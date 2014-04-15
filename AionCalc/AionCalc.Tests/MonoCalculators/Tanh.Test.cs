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
    public class Tanh
    {
        [Test]
        public void TanhTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("tanh");
            double result = calc.Calculate(1);
            Assert.AreEqual(0.76, result, 0.01);
        }
    }
}
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
    public class Sin
    {
        [Test]
        public void SinTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("sin");
            double result = calc.Calculate(1);
            Assert.AreEqual(0.84, result, 0.01);
        }
    }
}

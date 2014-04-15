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
    public class Cos
    {
        [Test]
        public void CosTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("cos");
            double result = calc.Calculate(1);
            Assert.AreEqual(0.53, result, 0.001);
        }
    }
}

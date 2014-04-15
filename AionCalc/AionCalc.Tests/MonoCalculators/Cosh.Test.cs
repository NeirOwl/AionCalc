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
    public class Cosh
    {
        [Test]
        public void CoshTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("cosh");
            double result = calc.Calculate(3);
            Assert.AreEqual(10.06, result, 0.01);
        }
    }
}

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
    public class Gradtorad
    {
        [Test]
        public void GradtoradTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("gradtorad");
            double result = calc.Calculate(10);
            Assert.AreEqual(0.17, result, 0.005);
        }
    }
}

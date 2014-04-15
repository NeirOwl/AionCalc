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
    public class Sinh
    {
        [Test]
        public void SinhTest()
        {
            IMonoCalculator calc = MonoOperationsFactory.CreateCalculator("sinh");
            double result = calc.Calculate(2);
            Assert.AreEqual(3.62, result, 0.01);
        }
    }
}

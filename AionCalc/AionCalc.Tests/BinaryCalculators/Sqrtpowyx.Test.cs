using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AionCalc.BinaryCalculators;
using NUnit.Framework;

namespace AionCalc.Tests.BinaryCalculators
{
    [TestFixture]
    public class Sqrtpowyx
    {
        [Test]
        public void SqrtpowyxTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("sqrtpowyx");
            double result = calc.Calculate(16, 4);
            Assert.AreEqual(2, result);
        }
    }
}
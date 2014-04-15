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
    public class Twomultiplyxdivisiony
    {
        [Test]
        public void TwomultiplyxdivisionyTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("2*x/y");
            double result = calc.Calculate(3, 2);
            Assert.AreEqual(3, result);
        }
    }
}

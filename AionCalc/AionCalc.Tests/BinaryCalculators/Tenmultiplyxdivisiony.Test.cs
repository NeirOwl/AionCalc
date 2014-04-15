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
    public class Tenmultiplyxdivisiony
    {
        [Test]
        public void TenmultiplyxdivisionyTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("10*x/y");
            double result = calc.Calculate(2, 4);
            Assert.AreEqual(5, result);
        }
    }
}

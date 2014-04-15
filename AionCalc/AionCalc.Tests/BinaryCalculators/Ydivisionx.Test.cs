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
    public class Ydivisionx
    {
        [Test]
        public void YdivisionxTest()
        {
            IBinaryCalculator calc = BinaryOperationsFactory.CreateCalculator("y/x");
            double result = calc.Calculate(3, 6);
            Assert.AreEqual(2, result);
        }
    }
}

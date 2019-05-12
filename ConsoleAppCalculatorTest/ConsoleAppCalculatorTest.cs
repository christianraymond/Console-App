using System;
using ConsoleAppCalculator.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppCalculator;

namespace ConsoleAppCalculatorTest
{
    [TestClass]
    public class ConsoleAppCalculatorTest
    {
        [TestMethod]
        public void NumberBetweenFiveIsNotValid()
        {
            ConsoleCalculator resultingValue = new ConsoleCalculator();
            bool getNumber;
            getNumber = resultingValue.Equals(6);
            Assert.IsTrue(getNumber);
        }

        [TestMethod]
        public void NumberBetweenFiveIsValid()
        {
            ConsoleCalculator resultingValue = new ConsoleCalculator();
            bool getNumber;
            getNumber = resultingValue.Equals(1);
            Assert.IsTrue(getNumber);

        }

        [TestMethod]
        public void InputValueNotNotAtest()
        {
            ConsoleCalculator resultingValue = new ConsoleCalculator();
            bool getNumber;
            getNumber = resultingValue.Equals("text");
            Assert.IsTrue(getNumber);
        }
    }
}

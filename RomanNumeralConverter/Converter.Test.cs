using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    [TestFixture]
    public class ConverterTest
    {
        Converter converter = new Converter();
       [Test]
       public void EmptyStringReturns0()
        {
            string input = "";
            int expectedOutput = 0;

            Assert.AreEqual(converter.ConvertNumerals(input), expectedOutput);
        }

        [Test]
        public void NumeralIReturnsOne()
        {
            string input = "I";
            int expectedOutput = 1;

            Assert.AreEqual(expectedOutput, converter.ConvertNumerals(input));
        }

        [Test]
        public void NumeralVReturnsFive()
        {
            string input = "V";
            int expectedOutput = 5;

            Assert.AreEqual(converter.ConvertNumerals(input), expectedOutput);
        }

        [Test]
        public void AddMultipleNumeralsTogether()
        {
            string input = "VI";
            int expectedOutput = 6;

            Assert.AreEqual(converter.ConvertNumerals(input), expectedOutput);
        }

        [Test]
        public void IVshouldSubtractAndReturnFour()
        {
            string input = "IV";
            int expectedOutput = 4;

            Assert.AreEqual(converter.ConvertNumerals(input), expectedOutput);
        }

        [Test]
        public void LargeRomanNumeralShouldReturnProperNumber()
        {
            string input = "MCMXLIV";
            int expectedOutput = 1944;

            Assert.AreEqual(converter.ConvertNumerals(input), expectedOutput);
        }
    }
}

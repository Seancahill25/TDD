using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    [TestFixture]
    class Test
    {
        Repeater repeat = new Repeater();
        [Test]
        public void ReturnInt()
        {
            var input = "";
            var num = 0;
            bool returnsInteger = (repeat.RepeatFunction(input, num).GetType() == typeof(int));
            Assert.IsTrue(returnsInteger);
        }
        [Test]
        public void IfEmptyStringReturnZero()
        {
            var input = "";
            var num = 0;
            var expected = 0;
            Assert.AreEqual(expected, repeat.RepeatFunction(input, num));
        }

        [Test]
        public void IfStringisAReturnNum()
        {
            var input = "a";
            var num = 1;
            var expected = 1;
            Assert.AreEqual(expected, repeat.RepeatFunction(input, num));
        }
        
        [Test]
        public void IfStringContainsAReturnAsFarAsNumCounts()
        {
            var input = "ba";
            var num = 1;
            var expected = 0;
            Assert.AreEqual(expected, repeat.RepeatFunction(input, num));
        }

        [Test]
        public void IfNumIsGreaterThanInputLengthRepeatString()
        {
            var input = "ba";
            var num = 4;
            var expected = 2;
            Assert.AreEqual(expected, repeat.RepeatFunction(input, num));
        }

        [Test]
        public void CheckStringOfLengthThreeWhereThereIsOneA()
        {
            var input = "aba";
            var num = 10;
            var expected = 7;
            Assert.AreEqual(expected, repeat.RepeatFunction(input, num));
        }
    }
}

using NUnit.Framework;
using LotteryService;

namespace Tests
{
    public class Tests  
    {
        Class1 _testService = new Class1();
        [Test]
        public void Return_Array()
        {
            int[]lotteryNumbers0 = new int[0];
            var output = _testService.SortNumbers(lotteryNumbers0);
            Assert.AreEqual(new int[0],output);
        }

        [Test]
        public void Return_OneNumSorted()
        {
            int[] lotteryNumbers1 = { 1 };
            var output = _testService.SortNumbers(lotteryNumbers1);
            Assert.AreEqual(lotteryNumbers1, output);
        }

        [Test]
        public void Return_twoNumSorted()
        {
            int[] lotteryNumbers2 = { 3, 2 };
            int[]  output = { 2, 3 };
            Assert.AreEqual(_testService.SortNumbers(lotteryNumbers2), output);
        }

        [Test]
        public void Return_threeNumSorted()
        {
            int[] lotteryNumbers2 = { 3, 2, 5 };
            int[] output = { 2, 3, 5 };
            Assert.AreEqual(_testService.SortNumbers(lotteryNumbers2), output);
        }

        [Test]
        public void Return_tenNumSorted()
        {
            int[] lotteryNumbers2 = { 3, 2, 6, 5, 7, 8, 1, 0, 4, 9 };
            int[] output = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.AreEqual(_testService.SortNumbers(lotteryNumbers2), output);
        }
    }
}
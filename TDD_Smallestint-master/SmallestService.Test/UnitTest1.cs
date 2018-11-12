using NUnit.Framework;
using SmallestService;
using System;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindSmallestInt(input));
        }

        [Test]
        public void IfArrayLengthIsOneReturnInt()
        {
            int[] array = { 1 };
            var output = 1;
            var finder = new Finder();
            Assert.AreEqual(finder.FindSmallestInt(array), output);
        }

        [Test]
        public void IfArrayLengthIsTwoReturnLowestInt()
        {
            int[] array = { 5, 2 };
            var output = 2;
            var finder = new Finder();
            Assert.AreEqual(output, finder.FindSmallestInt(array));
        }

        [Test]
        public void IfArrayLengthIsThreeReturnLowestInt()
        {
            int[] array = { 5, 2 , 8};
            var output = 2;
            var finder = new Finder();
            Assert.AreEqual(output, finder.FindSmallestInt(array));
        }

        [Test]
        public void IfArrayLengthIsGreaterThanZeroReturnSmallestInt()
        {
            int[] array = { 5, 2, 8, 7, 6, 4, 6, 5, 3, 1, 8, 9, 3 };
            var output = 1;
            var finder = new Finder();
            Assert.AreEqual(output, finder.FindSmallestInt(array));
        }
    }
}
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
            var array = new Finder();
            int[] intArr = { 1 };
            int expectedOutput = 1;
            var newArr = array.FindSmallestInt(intArr);
            Assert.AreEqual(expectedOutput, newArr);
        }

        [Test]
        public void IfArrayLengthIsTwoReturnLowestInt()
        {
            var array = new Finder();
            int[] intArr = { 1, 2 };
            int expectedOutput = 1;
            var newArr = array.FindSmallestInt(intArr);
            Assert.AreEqual(expectedOutput, newArr);
        }

        [Test]
        public void IfArrayLengthIsThreeReturnLowestInt()
        {
            var array = new Finder();
            int[] intArr = { 4, 3, 2 };
            int expectedOutput = 2;
            var newArr = array.FindSmallestInt(intArr);
            Assert.AreEqual(expectedOutput, newArr);
        }

        [Test]
        public void IfArrayLengthIsGreaterThanZeroReturnSmallestInt()
        {
            var array = new Finder();
            int[] intArr = { 4, 3, 2, 6, 1 };
            int expectedOutput = 1;
            var newArr = array.FindSmallestInt(intArr);
            Assert.AreEqual(expectedOutput, newArr);
        }
    }
}
using NUnit.Framework;
using SmallestService;
using System;

namespace Tests
{
    public class Tests2
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindClosestIntToZero(input));
        }

        [Test]
        public void FindClosestIntToZeroIfArrayLengthIsOneAndInputIsOneReturnOne()
        {
            var finder = new Finder();
            int[] input = { 1 };
            var output = 1;
            Assert.AreEqual(output, finder.FindClosestIntToZero(input));

        }

        [Test]
        public void FindClosestIntToZeroIfInputIsTwoAndThreeReturnsTwo()
        {
            var finder = new Finder();
            int[] input = { 3 , 2 };
            var output = 2;
            Assert.AreEqual(output, finder.FindClosestIntToZero(input));
        }

        [Test]
        public void IfInputLengthIsThreeReturnsClosestToZero()
        {
            var finder = new Finder();
            int[] input = { 3, 2 , 8};
            var output = 2;
            Assert.AreEqual(output, finder.FindClosestIntToZero(input));
        }

        [Test]
        public void IfInputContainsNegativeNumberReturnClosestToZero()
        {
            var finder = new Finder();
            int[] input = { 3, 2, 8 , -3};
            var output = 2;
            Assert.AreEqual(output, finder.FindClosestIntToZero(input));
        }

        [Test]
        public void IfInputContainsNegativeNumberAndPostiveNumberBothAreSameClosestToZeroReturnNegativeNumber()
        {
            var finder = new Finder();
            int[] input = { 3, 8, -3 };
            var output = -3;
            Assert.AreEqual(output, finder.FindClosestIntToZero(input));
        }
    }
}
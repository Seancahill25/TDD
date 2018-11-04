using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDalgorithm
{
    [TestFixture]
    class JumpingOnCloudsTest
    {
        [Test]
        public void InputLengthOneReturnsZero()
        {
            int[] cloudsArray = { 0 };
            int expected = 0;
            Assert.AreEqual(JumpingOnClouds.Calculate(cloudsArray), expected);
            
        }

        [Test]
        public void InputLengthTwoReturnsOne()
        {
            int[] cloudsArray = { 0, 0 };
            int expected = 1;
            Assert.AreEqual(JumpingOnClouds.Calculate(cloudsArray), expected);
        }

        [Test]
        public void JumpOverOneCloud()
        {
            int[] cloudsArray = { 0, 1, 0 };
            int expected = 1;
            
        }

        [Test]  
        public void JumpOverMultipleClouds()
        {
            int[] cloudsArray = { 0, 0, 1, 0, 0, 1, 0 };
            int expected = 4;
            Assert.AreEqual(JumpingOnClouds.Calculate(cloudsArray), expected);
        }

        [Test]
        public void JumpOverMultipleZeros()
        {
            int[] cloudsArray = { 0, 0, 0, 1, 0, 0 };
            int expected = 3;
            Assert.AreEqual(JumpingOnClouds.Calculate(cloudsArray), expected);
        }

    }
}

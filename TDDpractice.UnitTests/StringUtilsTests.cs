using NUnit.Framework;
using System;
using System.Linq;

namespace TDDpractice.UnitTests
{
    [TestFixture]
    public class StringUtilsTests
    {
        [Test]
        public void CountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome.";
            var characterToScanFor = "e";
            var expectedResult = 2;
            var stringUtils = new StringUtils();
            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CountNumberOfLettersInComplexSentence()
         {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            var characterToScanFor = "n";
            var expectedResult = 5;
            var stringUtils = new StringUtils();
            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);
 
            Assert.AreEqual(expectedResult, result);
        }
    }
}

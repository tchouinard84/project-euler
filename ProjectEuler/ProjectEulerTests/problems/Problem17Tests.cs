using NUnit.Framework;
using ProjectEuler.problems;

namespace ProjectEulerTests.problems
{
    [TestFixture]
    public class Problem17Tests
    {
        private Problem17 _problem17;

        [SetUp] public void Setup()
        {
            _problem17 = new Problem17();
        }

        [Test] public void Ensure1Returns3()
        {
            Assert.That(_problem17.NumberLetterCount(1), Is.EqualTo(3));
        }

        [Test] public void EnsureNumberToWordsForOnes()
        {
            AssertNumberToWords(0, "zero");
            AssertNumberToWords(1, "one");
            AssertNumberToWords(2, "two");
            AssertNumberToWords(3, "three");
            AssertNumberToWords(4, "four");
            AssertNumberToWords(5, "five");
            AssertNumberToWords(6, "six");
            AssertNumberToWords(7, "seven");
            AssertNumberToWords(8, "eight");
            AssertNumberToWords(9, "nine");
        }

        [Test] public void EnsureNumberToWordsForTeens()
        {
            AssertNumberToWords(10, "ten");
            AssertNumberToWords(11, "eleven");
            AssertNumberToWords(12, "twelve");
            AssertNumberToWords(13, "thirteen");
            AssertNumberToWords(14, "fourteen");
            AssertNumberToWords(15, "fifteen");
            AssertNumberToWords(16, "sixteen");
            AssertNumberToWords(17, "seventeen");
            AssertNumberToWords(18, "eighteen");
            AssertNumberToWords(19, "nineteen");
        }

        [Test] public void EnsureNumberToWordsForTens()
        {
            AssertNumberToWords(10, "ten");
            AssertNumberToWords(20, "twenty");
            AssertNumberToWords(30, "thirty");
            AssertNumberToWords(40, "forty");
            AssertNumberToWords(50, "fifty");
            AssertNumberToWords(60, "sixty");
            AssertNumberToWords(70, "seventy");
            AssertNumberToWords(80, "eighty");
            AssertNumberToWords(90, "ninty");
        }

        [Test] public void EnsureNumberToWordsForMixed()
        {
            AssertNumberToWords(24, "twenty-four");
            AssertNumberToWords(36, "thirty-six");
            AssertNumberToWords(24, "forty");
            AssertNumberToWords(24, "twenty-four");
            AssertNumberToWords(24, "twenty-four");
            AssertNumberToWords(24, "twenty-four");
        }

        private void AssertNumberToWords(int number, string expectedWords)
        {
            Assert.That(_problem17.NumberToWords(number), Is.EqualTo(expectedWords));
        }
    }
}
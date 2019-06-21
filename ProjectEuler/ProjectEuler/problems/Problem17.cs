using System.Collections.Generic;

namespace ProjectEuler.problems
{
    public class Problem17 : Problem
    {
        private static Dictionary<int, int> NumberLetterCounts;

        private static readonly string[] _ones =
            { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        private static readonly string[] _teens =
        {
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        private static readonly string[] _tens =
            { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninty" };

        public Problem17()
        {
            Title = "Number Letter Counts";
            Question =
                @"If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

            If all the numbers from 1 to 1000(one thousand) inclusive were written out in words, how many letters would be used?";
            Note = "Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of 'and' when writing out numbers is in compliance with British usage.";

            NumberLetterCounts = new Dictionary<int, int>
            {
                {1,3},
                {2,3},
                {3,5},
            };
        }

        public override int Solve() => Solve(1, 1000);

        public int Solve(int from, int to)
        {
            return 0;
        }

        public int NumberLetterCount(int number)
        {
            if (number == 1) { return 3; }
            return 3;
        }

        public string NumberToWords(int number)
        {
            if (number < 0) { return "negative"; }

            if (number > 19) { return _tens[number / 10] + "-" + NumberToWords(number%10); }
            if (number > 9) { return _teens[number - 10]; }
            return _ones[number];
        }
    }
}

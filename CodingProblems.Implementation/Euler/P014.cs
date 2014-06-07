using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    /*
        The following iterative sequence is defined for the set of positive longegers:
        n → n/2 (n is even)
        n → 3n + 1 (n is odd)

        Using the rule above and starting with 13, we generate the following sequence:

        13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

        Which starting number, under one million, produces the longest chain?

        NOTE: Once the chain starts the terms are allowed to go above one million.
     */
    public class P014
    {
        public long GetLowestCollatzNumberLessThanN(int n)
        {
            var collatzNumbers = Enumerable.Range(1, n - 1)
                .Select(x => new { N = x, CollatzTerms = GetNumberOfTermsInCollatzSequence(x) })
                .ToList();

            var longestSequence = collatzNumbers.Max(x => x.CollatzTerms);

            collatzNumbers.Where(x => x.CollatzTerms == longestSequence).Min(x => x.N);

            return (
                from collatzNumber in collatzNumbers
                where collatzNumber.CollatzTerms == longestSequence
                select collatzNumber).Min(x => x.N);

        }

        private Dictionary<long, long> collatzValues = new Dictionary<long, long>() { { 1, 1 } };

        public long GetNumberOfTermsInCollatzSequence(long n)
        {
            if (collatzValues.Keys.Contains(n))
                return collatzValues[n];

            var nextCollatzValue = NextCollatzValue(n);
            
            var collatzValue = GetNumberOfTermsInCollatzSequence(nextCollatzValue) + 1;
            collatzValues.Add(n, collatzValue);
            return collatzValue;
        }

        private long NextCollatzValue(long n)
        {
            if (n % 2 == 0)
                return n / 2;

            return (3 * n) + 1;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingProblems.Implementation.Euler
{
    public class P004
    {
        public static bool IsPalendrome(int n)
        {
            var digits = n.ToString();
            var midPoint = GetMidPoint(digits.Length);
            for (int index = 0; index <= midPoint; index++)
            {
                if (digits[index] != digits[digits.Length - 1 - index])
                    return false;
            }
            return true;
        }
        public static int GetMidPoint(int length)
        {
            return length / 2 + ((length % 2 == 0) ? 0 : 1);
        }

        public static int GetMaxPalindromeProduct(int min, int max)
        {
            var sequence = Enumerable.Range(min, 1 + max - min).ToList();

            var palindromeProducts = (
                from n1 in sequence
                from n2 in sequence
                let product = n1 * n2
                where IsPalendrome(product)
                select new { n1, n2, product }
            ).ToList();
            var maxProduct = palindromeProducts.Max(x => x.product);
            var maxProductNumbers = palindromeProducts.Where(x => x.product == maxProduct).ToList();

            return maxProduct;
        }
    }
}

using System;
using System.Collections.Generic;

namespace PracticeProgramming.ProjectEuler
{
    public static class LargestPalindromeProduct
    {
        public static void SolveProblem()
        {
            // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.
            // Find the largest palindrome made from the product of two 3 - digit numbers.
            // C style solution
            // Problem: Solved 

            var minNumber = 100;
            var maxNumber = 999;
            var product = 0;
            var largestPalindrome = 0;

            for (var i = minNumber; i <= maxNumber; i++)
            {
                for (var j = minNumber; j < maxNumber; j++)
                {
                    product = i * j;

                    if (IsPalindrome(product) && product > largestPalindrome)
                    {
                        largestPalindrome = product;
                    }
                }
            }

            Console.WriteLine(largestPalindrome);
        }

        private static bool IsPalindrome(int number)
        {
            var digits = GetDigits(number);

            var myNumber = 0;

            for (var i = digits.Count - 1; i >= 0; i--)
            {
                myNumber += digits[i] * ((int)Math.Pow(10, i));
            }

            return number == myNumber;
        }

        private static int GetNumberOfDigits(int number)
        {
            var digits = 1;

            while (number >= Math.Pow(10, digits))
            {
                digits++;
            }

            return digits;
        }

        private static List<int> GetDigits(int number)
        {
            var numberOfDigits = GetNumberOfDigits(number);
            var digits = new List<int>();

            for (var i = numberOfDigits - 1; i >= 0; i--)
            {
                var divisor = (int)(Math.Pow(10, i));
                var myNumber = (number / divisor);
                digits.Add(myNumber);

                number = number - (myNumber * divisor);
            }

            return digits;
        }
    }
}

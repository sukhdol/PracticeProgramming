using System;

namespace PracticeProgramming.ProjectEuler
{
    public static class PrimeNumber10001
    {
        public static void SolveProblem()
        {
            // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            // What is the 10 001st prime number ?
            // Problem: Solved

            const int targetPrimeNumber = 10001;
            var primeCounter = 0;
            var counter = 1;

            while (primeCounter < targetPrimeNumber)
            {
                counter++;

                if (IsPrimeNumber(counter))
                {
                    primeCounter++;
                }
            }

            Console.WriteLine(counter);
        }

        public static bool IsPrimeNumber(int number)
        {
            var halfOfNumber = number / 2;

            for (var i = 2; i <= halfOfNumber; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

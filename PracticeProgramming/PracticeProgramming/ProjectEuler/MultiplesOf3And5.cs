using System;

namespace PracticeProgramming.ProjectEuler
{
    public static class MultiplesOf3And5
    {
        public static void SolveProblem()
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000.
            // Solution: Solved

            const int maxNumber = 1000;
            var sum = 0;

            for (var i = 1; i < maxNumber; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

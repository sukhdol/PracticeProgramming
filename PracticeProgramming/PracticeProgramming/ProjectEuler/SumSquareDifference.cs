using System;

namespace PracticeProgramming.ProjectEuler
{
    public static class SumSquareDifference
    {
        public static void SolveProblem()
        {
            // The sum of the squares of the first ten natural numbers is,
            // 12 + 22 + ... + 102 = 385
            // The square of the sum of the first ten natural numbers is,
            // (1 + 2 + ... + 10)2 = 552 = 3025
            // Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
            // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
            // Problem: Solved

            const int minNumber = 1;
            const int maxNumber = 100;

            var sumOfSquares = 0;
            var squareOfSum = 0;

            for (var i = minNumber; i <= maxNumber; i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;
            }

            var difference = (squareOfSum * squareOfSum) - sumOfSquares;

            Console.WriteLine(difference);
        }

    }
}

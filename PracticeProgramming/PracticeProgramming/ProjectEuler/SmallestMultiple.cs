using System;

namespace PracticeProgramming.ProjectEuler
{
    public static class SmallestMultiple
    {
        public static void SolveProblem()
        {
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?

            const int minNumber = 1;
            const int maxNumber = 20;
            var counter = maxNumber;
            var tempCounter = 0;
            bool isDivisible;
            isDivisible = false;

            while (!isDivisible)
            {
                counter++;

                for (var i = minNumber; i <= maxNumber; i++)
                {
                    tempCounter = i;
                    if (counter % i != 0)
                    {
                        break;
                    }
                }

                if (tempCounter == maxNumber)
                {
                    Console.WriteLine(counter);
                    isDivisible = true;
                }
            }
        }

    }
}

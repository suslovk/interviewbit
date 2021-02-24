using System;
using System.Collections.Generic;

namespace arrays
{
    public class PrimeSum
    {
        public static int[] Calculate(int sum)
        {
            var primes = GetPrimeNumbersSmallerThan(sum);
            return FindSumDuplet(primes, sum);
        }

        private static int[] FindSumDuplet(List<int> primes, int sum)
        {
            int smallerIdx = 0, greaterIdx = primes.Count - 1;
            while (smallerIdx >= 0 && greaterIdx < primes.Count && smallerIdx <= greaterIdx)
            {
                var actualSum = primes[smallerIdx] + primes[greaterIdx];
                if (actualSum < sum)
                    smallerIdx++;
                else if (actualSum > sum)
                    greaterIdx--;
                else return new[] {primes[smallerIdx], primes[greaterIdx]};
            }

            return null;
        }

        private static List<int> GetPrimeNumbersSmallerThan(int sum)
        {
            var notPrimes = new bool[sum + 1];
            notPrimes[0] = true;
            notPrimes[1] = true;

            for (var i = 2; i <= Math.Sqrt(sum); i++)
            {
                if (notPrimes[i])
                    continue;

                for (var j = 2; i * j <= sum; j++)
                    notPrimes[i * j] = true;
            }

            var result = new List<int>();
            for (var i = 2; i < notPrimes.Length; i++)
                if (!notPrimes[i])
                    result.Add(i);

            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals_Assignment1_PrimeNumber_DAY2
{
    public class PrimeNumberFinder
    {
        public static Task<List<int>> FindPrimesInRangeAsync(int start, int end)
        {
            return Task.Run(() => FindPrimesInRange(start, end));
        }
        private static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (PrimeNumber.IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

    }
}

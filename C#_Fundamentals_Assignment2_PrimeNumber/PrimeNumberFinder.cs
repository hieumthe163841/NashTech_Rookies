namespace C__Fundamentals_Assignment2_PrimeNumber
{
    public class PrimeNumberFinder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static async Task<List<int>> FindPrimesInRangeAsync(int start, int end)
        {
            return await Task.Run(async () =>
            {
                List<int> primes = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    if (await PrimeNumber.IsPrimeAsync(i))
                    {
                        primes.Add(i);
                    }

                }
                return primes;
            });

        }
    }
}

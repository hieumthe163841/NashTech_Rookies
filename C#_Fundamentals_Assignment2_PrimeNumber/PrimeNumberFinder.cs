namespace C__Fundamentals_Assignment2_PrimeNumber
{
    public class PrimeNumberFinder
    {
   
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
                        Thread.Sleep(100);
                    }

                }
                return primes;
            });

        }
    }
}

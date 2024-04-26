using C__Fundamentals_Assignment1_PrimeNumber_DAY2;

internal class Program
{
    public static async Task Main(string[] args)
    {
        int startRange = ValidationInput.IsValidInput("Enter startRange: ");
        int endRange = ValidationInput.IsValidInput("Enter endRange: ");
        if(startRange >= endRange)
        {
            Console.WriteLine("Invalid input. Start range must be less than end range.");
            return;
        }
        else
        {
            List<int> primeNumbers = await PrimeNumberFinder.FindPrimesInRangeAsync(startRange, endRange);
            Console.WriteLine($"Prime numbers between {startRange} and {endRange} are:");
            foreach (int prime in primeNumbers)
            {
                Console.Write($"{prime} ");
            }
        }
        Console.ReadKey();
    }
}
using C__Fundamentals_Assignment2_PrimeNumber;

class Program
{
    public static async Task Main(string[] args)
    {
        int startRange = ValidationInput.IsValidInput("Enter startRange: ");
        int endRange = ValidationInput.IsValidInput("Enter endRange: ");
        while (startRange >= endRange)
        {
            Console.WriteLine("Invalid input. Start range must be less than end range.");
            startRange = ValidationInput.IsValidInput("Enter startRange: ");
            endRange = ValidationInput.IsValidInput("Enter endRange: ");
        }

        List<Task<List<int>>> tasks = new List<Task<List<int>>>();
        int partitionSize = 10;
        for(int i = startRange; i <= endRange; i += partitionSize)
        {
            int start = i;
            int end = i + partitionSize - 1;
            if(end > endRange)
            {
                end = endRange;
            }
            tasks.Add(PrimeNumberFinder.FindPrimesInRangeAsync(start, end));
        }

        await Task.WhenAll(tasks);

        List<int> primeNumbers = tasks.SelectMany(t => t.Result).ToList();

        Console.WriteLine($"Prime numbers between {startRange} and {endRange} are:");
        foreach (int prime in primeNumbers)
        {
            Console.Write($"{prime} ");
        }
        Console.ReadLine();


    }
}
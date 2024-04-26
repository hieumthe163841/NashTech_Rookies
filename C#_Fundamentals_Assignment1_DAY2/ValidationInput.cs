namespace C__Fundamentals_Assignment1_DAY2
{
    public class ValidationInput
    {
        public static int CheckInputInt(string input)
        {
            int number;
            while (true)
            {
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Invalid. Please enter a number");
                    Console.WriteLine("Enter a number:");
                    input = Console.ReadLine();
                }
                else
                {
                    return number;
                }
            }
        }
    }
}

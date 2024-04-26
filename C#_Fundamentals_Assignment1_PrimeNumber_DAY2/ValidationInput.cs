﻿namespace C__Fundamentals_Assignment1_PrimeNumber_DAY2
{
    public class ValidationInput
    {
        public static int IsValidInput(string message)
        {
            Console.WriteLine(message);
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int input) && input > 0)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer!");
                    Console.Write("Enter a positive integer: ");
                }
            }
        }
    }
}

﻿namespace C__Fundamentals_Assignment1_PrimeNumber_DAY2
{
    public class PrimeNumber
    {
       

        public static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

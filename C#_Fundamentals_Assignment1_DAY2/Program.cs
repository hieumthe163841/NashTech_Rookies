// See https://aka.ms/new-console-template for more information
using C__Fundamentals_Assignment1_DAY2;

public class Program
{
    public static void Main(string[] args)
    {

        ManagementMember managementMember = new ManagementMember();
        int choice;
        while (true)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Get Male Students");
            Console.WriteLine("2. Get Oldest Member");
            Console.WriteLine("3. Get FullName List");
            Console.WriteLine("4. Get Member who has birth year");
            Console.WriteLine("5. Get first person who was born in Ha Noi");
            Console.WriteLine("6. Clear Console");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice");

            string choiceInput = Console.ReadLine();
            if (!int.TryParse(choiceInput, out choice))
            {
                Console.WriteLine("Invalid. Please enter a number");
                continue;
            }
            else
            {
                switch (choice)
                {
                    case 1:

                        managementMember.GetMaleStudents();
                        break;
                    case 2:
                        managementMember.GetOldMember();
                        break;
                    case 3:
                        managementMember.GetFullNameList();
                        break;
                    case 4:
                        managementMember.Get3List();
                        break;
                    case 5:
                        managementMember.GetFirstPersonBornInHaNoi();
                        break;
                    case 6:
                        Utils.ClearConsole();
                        break;
                    case 0:
                        Console.WriteLine("Exit program...");
                        return;
                    default:
                        Console.WriteLine("Please choice number of range from 0 to 6");
                        break;
                }
            }




        }
    }

}

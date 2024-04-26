namespace C__Fundamentals_Assignment1
{
    public class ManagementMember
    {
        List<Member> members = GetMembers();
        public void GetMaleStudents()
        {
            Console.WriteLine("\nMale Members: ");
            foreach (var member in members)
            {
                if (member.Gender == "Male")
                {
                    Console.WriteLine($"{member.FullName}");
                }
            }
        }
        public void GetOldMember()
        {
            Console.WriteLine("\nOldest Member: ");
            Member oldestMember = null;
            foreach (var member in members)
            {
                if (oldestMember == null || member.DateOfBirth < oldestMember.DateOfBirth)
                {
                    oldestMember = member;
                }
            }
            Console.WriteLine($"{oldestMember.FullName} - Age: {oldestMember.Age}");
        }
        public void GetFullNameList()
        {
            Console.WriteLine("\nFull Name List: ");
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FirstName} {member.LastName}");
            }
        }
        public void Get3List()
        {
            while (true)
            {
                Console.WriteLine("4. Get Member who has birth year");
                Console.WriteLine("     1. Get Members Born In a Year ");
                Console.WriteLine("     2. Get Members After a Year ");
                Console.WriteLine("     3. Get Members Before a Year ");
                Console.WriteLine("     0. Exit to Menu ");
                Console.WriteLine("Enter your choice:");
                string choiceInput = Console.ReadLine();
                int choice;
                if (!int.TryParse(choiceInput, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number");
                    continue;
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            GetMembersBornInAYear();
                            break;
                        case 2:
                            GetMembersAfterAYear();
                            break;
                        case 3:
                            GetMembersBornBeforeAYear();
                            break;
                        case 0:
                            return;
                    }
                }
            }
           
        }
        public void GetMembersBornInAYear()
        {
            Console.WriteLine("Enter your years:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nMembers born in {year}: ");
            foreach (var member in members)
            {
                if (member.DateOfBirth.Year == year)
                {
                    Console.WriteLine($"{member.FullName} - BirthDate: {member.DateOfBirth.Year}");
                }
            }
        }
        public void GetMembersAfterAYear()
        {
            Console.WriteLine("Enter your years:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nMembers born after {year}: ");
            foreach (var member in members)
            {
                if (member.DateOfBirth.Year > year)
                {
                    Console.WriteLine($"{member.FullName} - BirthDate: {member.DateOfBirth.Year} ");
                }
            }
        }
        public void GetMembersBornBeforeAYear()
        {
            Console.WriteLine("Enter your years:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nMembers born before {year}: ");
            foreach (var member in members)
            {
                if (member.DateOfBirth.Year < year)
                {
                    Console.WriteLine($"{member.FullName} BirthDate: {member.DateOfBirth.Year}");
                }
            }
        }
        public void GetFirstPersonBornInHaNoi()
        {
            Console.WriteLine("\nFirst person who was born in Ha Noi: ");

            while (true)
            {
                foreach (var member in members)
                {
                    if (member.BirthPlace == "Ha Noi")
                    {
                        Console.WriteLine($"{member.FullName} - born in {member.BirthPlace}");
                        break;
                    }

                }
                break;
            }
        }
        public static List<Member> GetMembers()
        {
            return new List<Member>()
        {
            new Member()
            {
                FirstName = "Mai Trong",
                LastName = "Hieu",
                Gender = "Male",
                DateOfBirth = new DateTime(2002, 04, 02),
                PhoneNumber = "0943317918",
                BirthPlace = "Ha Tinh",
                IsGraduated = false
            },
            new Member()
            {
                FirstName = "Truong Trong",
                LastName = "Hoa",
                Gender = "Male",
                DateOfBirth = new DateTime(2002, 05, 12),
                PhoneNumber = "0941829321",
                BirthPlace = "Thanh Hoa",
                IsGraduated = false
            },
            new Member()
            {
                FirstName = "Nguyen Minh",
                LastName = "Anh",
                Gender = "Female",
                DateOfBirth = new DateTime(2001,09,12),
                PhoneNumber = "0941234921",
                BirthPlace = "Ha Noi",
                IsGraduated = true
            },
            new Member()
            {
                FirstName = "Hoang Nhat",
                LastName = "Minh",
                Gender = "Male",
                DateOfBirth = new DateTime(2002, 06, 12),
                PhoneNumber = "0943334921",
                BirthPlace = "Ha Nam",
                IsGraduated = false
            },
            new Member()
            {
                FirstName = "La Thien",
                LastName = "Vu",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 07, 13),
                PhoneNumber = "0943334123",
                BirthPlace = "Ha Noi",
                IsGraduated = true

            },
            new Member()
            {
                FirstName = "Nguyen Ngoc",
                LastName = "Quang",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 08, 12),
                PhoneNumber = "0941134921",
                BirthPlace = "Nghe An",
                IsGraduated = true
            },
            new Member()
            {
                FirstName = "Le Viet",
                LastName = "Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2003, 09, 22),
                PhoneNumber = "0943345921",
                BirthPlace = "Ha Giang",
                IsGraduated = false
            }
        };

        }

    }
}

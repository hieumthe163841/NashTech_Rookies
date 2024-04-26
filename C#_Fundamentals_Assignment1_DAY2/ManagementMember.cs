namespace C__Fundamentals_Assignment1_DAY2
{
    public class ManagementMember
    {
        List<Member> members = GetMembers();
        public void GetMaleStudents()
        {
            Console.WriteLine("Male Members: ");
            var maleMembers = members.Where(member => member.Gender == "Male");
            foreach (var member in maleMembers)
            {
                Console.WriteLine($"{member.ToString()}");
            }
           
        }
        public void GetOldMember()
        {
            Console.WriteLine("Oldest Member: ");
            Member oldestMember = null;
            oldestMember = members.OrderBy(member => member.DateOfBirth).FirstOrDefault();
            Console.WriteLine($"{oldestMember.ToString()}");
        }
        public void GetFullNameList()
        {
            Console.WriteLine("\nFull Name List: ");
            var fullNameList = members.Select(member => $"{member.FirstName} {member.LastName}");
            foreach (var member in fullNameList)
            {
                Console.WriteLine($"{member}");
            }
        }
        public void ManageMemberBirthYearQueries()
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
                int choice = ValidationInput.CheckInputInt(choiceInput);
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
                        default:
                            Console.WriteLine("Please choice number of range from 0 to 3");
                            break;
                    }
                
            }
           
        }
        public void GetMembersBornInAYear()
        {
            Console.WriteLine("Enter your years:");
            int year = ValidationInput.CheckInputInt(Console.ReadLine());
            Console.WriteLine($"Members born in {year}: ");
            var membersInYear = members.Where(member => member.DateOfBirth.Year == year);
            if(membersInYear.Count() == 0)
            {
                Console.WriteLine("No member was born in this year");
            }
            else
            {
                foreach (var member in membersInYear)
                {
                    Console.WriteLine($"{member.ToString()}");
                }
            }
            
        }
        public void GetMembersAfterAYear()
        {
            Console.WriteLine("Enter your years:");
            int year = ValidationInput.CheckInputInt(Console.ReadLine());
            Console.WriteLine($"Members born after {year}: ");
            var memberAfterYear = members.Where(member => member.DateOfBirth.Year > year);
            if(memberAfterYear.Count() == 0)
            {
                Console.WriteLine("No member was born after this year");
            }
            else
            {
                foreach (var member in memberAfterYear)
                {
                    Console.WriteLine($"{member.ToString()}");
                }
            }
            
        }
        public void GetMembersBornBeforeAYear()
        {
            Console.WriteLine("Enter your years:");
            int year = ValidationInput.CheckInputInt(Console.ReadLine());
            Console.WriteLine($"Members born before {year}: ");
            var memberBeforeYear = members.Where(member => member.DateOfBirth.Year < year);
            if(memberBeforeYear.Count() == 0)
            {
                Console.WriteLine("No member was born before this year");
            }
            else
            {
                foreach (var member in memberBeforeYear)
                {
                    Console.WriteLine($"{member.ToString()}");
                }
            }
            
        }
        public void GetFirstPersonBornInHaNoi()
        {
            Console.WriteLine("First person who was born in Ha Noi: ");

            var firstPersonInHaNoi = members.FirstOrDefault(members => members.BirthPlace == "Ha Noi");
            if(firstPersonInHaNoi != null)
            {
                Console.WriteLine($"{firstPersonInHaNoi.ToString()}");
            }
            else
            {
                Console.WriteLine("No person was born in Ha Noi");
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

namespace C__Fundamentals_Assignment1
{
    public class Member
    {
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public bool IsGraduated { get; set; }
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
        public string FullName => FirstName + " " + LastName;


    }
}

﻿namespace C__Fundamentals_Assignment1_DAY2
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

        public override string ToString()
        {
            return $"{FullName} | {Gender} | {DateOfBirth} | {PhoneNumber} | {BirthPlace} | {IsGraduated} | {Age}";
        }
    }
}

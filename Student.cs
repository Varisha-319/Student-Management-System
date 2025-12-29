using System;

namespace StudentsInfoSystem
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate, string email, string phone, string address, string postalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
            Address = address;
            PostalCode = postalCode;
        }
    }
}

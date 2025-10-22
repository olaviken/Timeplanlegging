using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace BlazorTest.Components.Classes
{
    class Educator
    {
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public DateTime BirthDate { get; private set; }
        public string UserName { get; private set; } = string.Empty;
        public string Position { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        
        public string SubjectUnit { get; private set; } = string.Empty;
        public string Education { get; private set; } = string.Empty;
        public string Specialization { get; private set; } = string.Empty;

        
        public int Age { get; private set; }
        public int HoursForEducation { get; private set; }

        public Educator() { }

        public Educator(string firstName, string lastName, DateTime birthDate, string userName, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            UserName = userName;
            Position = position;
        }

        public void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                throw new ArgumentException("Invalid email address.");
            }
            Email = email.Trim();
        }
        public static int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today; 
            var age = today.Year - birthDate.Year;

            if (birthDate == DateTime.MinValue)
            {
                throw new InvalidOperationException("BirthDate is not set.");
            }
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;

            
        }
    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace BlazorTest.Components.Classes
{
    class Educator
    {
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public DateTime BirthDate { get; private set; }
        public string Position { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        
        public string SubjectUnit { get; private set; } = string.Empty;
        public string Education { get; private set; } = string.Empty;
        public string Specialization { get; private set; } = string.Empty;
        
        public int percentagePosition { get; private set; } = 100;

        

        public int Age
        {
            get
            {
                return CalculateAge(BirthDate);
            }
        }
        
        public float HoursForEducation
        {
            get
            {
                return CalculateHoursForEducation(BirthDate, Position, percentagePosition);
            }
        }



        public Educator() { }

        public Educator(string firstName, string lastName, DateTime birthDate, string email, string position)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
               throw new ArgumentException("Last name cannot be empty.");
            }
            if (birthDate == DateTime.MinValue || birthDate > DateTime.Today)
            {
                throw new ArgumentException("Invalid birth date.");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("User name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentException("Position cannot be empty.");
            }
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
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
            if (birthDate == DateTime.MinValue)
            {
                throw new InvalidOperationException("BirthDate is not set.");
            }
            if(birthDate > DateTime.Today)
            {
                throw new ArgumentException("Birth date cannot be in the future.");
            }
            var today = DateTime.Today; 
            var age = today.Year - birthDate.Year;

            
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
            
        }

        public void SetEducationDetails(string subjectUnit, string education, string specialization)
        {
            SubjectUnit = subjectUnit;
            Education = education;
            Specialization = specialization;
        }

        
        public float CalculateHoursForEducation(DateTime birthDate, string position, int percentagePosition)
        {
            /* This methods depends on how old the educator is and its position. 
         If an educator is 60 years old or older the receive 5 days more in vacation.
         If an educator is 62 years old or older the receive an extra 5 days in vacation.
         by position:
            - Professor: has 45% of hours for education
            - Associate Professor: has 45% of hours for education
            - Other: has 80% of hours for education
            
        Also baseline for hours of work is 1675 hours per year. One work day is 7,5 hours. Making a work week of 37,5 hours.
         */
            float standardHours = 1687.5f;
            float reducedHours = 0f;
            float positionFactor = 0f;
           
            int Age = CalculateAge(birthDate);

            if (Age >= 62)
            {
                reducedHours = 75f; 
            }
            else if (Age >= 60)
            {
                reducedHours = 37.5f;
            }

            if (position.Equals("Professor", StringComparison.OrdinalIgnoreCase) ||
                position.Equals("Førsteamanuensis", StringComparison.OrdinalIgnoreCase))
            {
                positionFactor = 0.45f;
            }
            else
            {
                positionFactor = 0.80f;
            }

            float hoursForEducation = (percentagePosition/100)*((standardHours - reducedHours) * positionFactor);
            return hoursForEducation;
        }

        public float CalculateHoursForRND(DateTime birthDate, string position, int percentagePosition) {
            /* 
             * Similar to CalculateHoursForEducation but for RND activities.
             */
            float standardHours = 1687.5f;
            float reducedHours = 0f;
            float positionFactor = 0f;

            int Age = CalculateAge(birthDate); 
            if (Age >= 62)
            {
                reducedHours = 75f; 
            }
            else if (Age >= 60)
            {
                reducedHours = 37.5f;
            }
            if (position.Equals("Professor", StringComparison.OrdinalIgnoreCase) ||
                position.Equals("Førsteamanuensis", StringComparison.OrdinalIgnoreCase))
            {
                positionFactor = 0.45f;
            }
            else
            {
                positionFactor = 0.20f;
            }
            float hoursForRND = (percentagePosition/100)*((standardHours - reducedHours) * positionFactor);

            return hoursForRND;
        }
    }
}

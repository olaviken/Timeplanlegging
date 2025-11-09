using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace BlazorTest.Components.Classes
{
    public class Educator
    {
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public DateTime BirthDate { get; private set; }
        public string Position { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        
        public string SubjectUnit { get; private set; } = string.Empty;
        public string Education { get; private set; } = string.Empty;
        public string Specialization { get; private set; } = string.Empty;
        
        public int PercentagePosition { get; private set; } = 100;

        

        public int Age
        {
            get
            {
                return CalculateAge(BirthDate);
            }
        }
        
        public float HoursEducationFall
        {
            get
            {
                return CalculateHoursForEducationFall(BirthDate, Position, PercentagePosition);
            }
        }
        public float HoursEducationSpring
        {
            get
            {
                return CalculateHoursForEducationSpring(BirthDate, Position, PercentagePosition);
            }
        }

        

        public Educator() { }

        public Educator(string firstName, string lastName, DateTime birthDate, string email, string position, int percentage)
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
                if (percentage < 1 || percentage > 100)
                {
                    throw new ArgumentOutOfRangeException("Percentage position must be between 1 and 100.");
                }
                FirstName = firstName;
                LastName = lastName;
                BirthDate = birthDate;
                this.SetEmail(email);
                Position = position;
                PercentagePosition = percentage;
            

        }

        public void SetEmail(string email)
        {

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                {
                    throw new ArgumentException("Invalid email address.");
                }
                Email = email.Trim();
            

        }
        public static int CalculateAge(DateTime birthDate)
        {
            if (birthDate == DateTime.MinValue)
                throw new ArgumentException("BirthDate is not set.", nameof(birthDate));
            if (birthDate > DateTime.Today)
                throw new ArgumentException("Birth date cannot be in the future.", nameof(birthDate));

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

        
        public float CalculateHoursForEducationFall(DateTime birthDate, string position, int percentagePosition)
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
            float standardHours = 767;
            float reducedHours = 0f;
            float positionFactor;

            int Age = CalculateAge(birthDate);

            if (Age + 1 >= 60)
            {
                reducedHours += 9.32f;
            }
            if (Age >= 60)
            {
                reducedHours += 7.73f;
            }
            if (Age + 1 >= 62)
            {
                reducedHours += 14.86f;
            }
            if (Age >= 62)
            {
                reducedHours += 12.41f;
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

            float hoursForEducation = (percentagePosition / 100f) * ((standardHours - reducedHours) * positionFactor);
            return MathF.Round(hoursForEducation,2);
        }

        public float CalculateHoursForEducationSpring(DateTime birthDate, string position, int percentagePosition)
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
            float standardHours = 920.5F;
            float reducedHours = 0f;
            float positionFactor;

            int Age = CalculateAge(birthDate);

            if (Age + 1 >= 60)
            {
                reducedHours += 9.32f;
            }
            if (Age >= 60)
            {
                reducedHours += 7.73f;
            }
            if (Age + 1 >= 62)
            {
                reducedHours += 14.86f;
            }
            if (Age >= 62)
            {
                reducedHours += 12.41f;
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

            float hoursForEducation = (percentagePosition / 100f) * ((standardHours - reducedHours) * positionFactor);
            return MathF.Round(hoursForEducation, 2);
        }
        
        
        
    }
}

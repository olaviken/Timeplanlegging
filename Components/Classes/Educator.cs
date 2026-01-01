


namespace BlazorTest.Components.Classes
{
    public class Educator
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = string.Empty;
        
        public string Education { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        
        public int PercentagePosition { get; set; } = 100;
        public int PercentageRND { get; set; } = 20;


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
                return CalculateHoursForEducationFall(BirthDate, PercentageRND, PercentagePosition);
            }
        }
        public float HoursEducationSpring
        {
            get
            {
                return CalculateHoursForEducationSpring(BirthDate, PercentageRND, PercentagePosition);
            }
        }

        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        public static int CalculateAge(DateTime birthDate)
        {
            /*if (birthDate == DateTime.MinValue)
                throw new ArgumentException("BirthDate is not set.", nameof(birthDate));
            if (birthDate > DateTime.Today)
                throw new ArgumentException("Birth date cannot be in the future.", nameof(birthDate));*/

            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        

        
        public float CalculateHoursForEducationFall(DateTime birthDate, int RND, int percentagePosition)
        {
            /* This methods depends on how old the educator is and its position. 
         If an educator is 60 years old or older the receive 5 days more in vacation.
         If an educator is 62 years old or older the receive an extra 5 days in vacation.
         Remove position. add a percentage for RND instead.

        Also baseline for hours of work is 1675 hours per year. One work day is 7,5 hours. Making a work week of 37,5 hours.
         */

            float standardHours = 767;
            float reducedHours = 0f;
                        
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

            float hours = (standardHours - reducedHours);
            float educationpercentage = (100 - RND) / 100f;
            float forEducation = hours * educationpercentage;

            float hoursForEducation = (percentagePosition / 100f)*forEducation;
            return MathF.Round(hoursForEducation,2);
        }

        public float CalculateHoursForEducationSpring(DateTime birthDate, int RND, int percentagePosition)
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
            float hours = (standardHours - reducedHours);
            float educationpercentage = (100 - RND) / 100f;
            float forEducation = hours * educationpercentage;

            float hoursForEducation = (percentagePosition / 100f) * forEducation;
            return MathF.Round(hoursForEducation, 2);
        }
        
        
        
    }
}

namespace BlazorTest.Components.Classes
{
    public class Activity
    {
        public string ActivityID { get; private set; } = Guid.NewGuid().ToString();
        public DateTime ActivityDate { get; private set; }
        public string ActivityName { get; private set; } = string.Empty;
        public float ActivityHours { get; private set; } = 0f;

        public float CalculatedHours { get; private set; } = 0f;

        public string ActivityCategory { get; set; } = string.Empty;

        public string Field { get; set; } = string.Empty;
        public string ActivityDescription { get; private set; } = string.Empty;
        public string EducatorFirstName { get; private set; } = string.Empty;
        public string EducatorLastName { get; private set; } = string.Empty;




        public Activity() { }

        public Activity(string ActivityID, DateTime activitydate, string activityname, float activityhours, 
                        float calculatedhours, string activitycategory, string activitydescription, string educatorfirstname, 
                        string educatorlastname, string field)
        {
            SetActivityDate(activitydate);
            SetActivityName(activityname);
            SetActivityHours(activityhours);
            SetCalculatedHours(calculatedhours);
            SetActivityCategory(activitycategory);
            SetActivityDescription(activitydescription);
            SetEducatorName(educatorfirstname, educatorlastname);
            SetField(field);
        }


        public void SetActivityDate(DateTime activitydate)
        {
            if (activitydate > DateTime.Now)
            {
                throw new ArgumentException("Activity date cannot be in the future.");
            }
            ActivityDate = activitydate;
        }

        public void SetActivityName(string activityname)
        {
            if (string.IsNullOrWhiteSpace(activityname))
            {
                throw new ArgumentException("Activity name cannot be empty.");
            }
            ActivityName = activityname;
        }

        public void SetActivityHours(float activityhours)
        {
            if (activityhours <= 0)
            {
                throw new ArgumentException("Activity hours must be greater than zero.");
            }
            //add multipliers from field
            ActivityHours = activityhours;
        }



        public void SetActivityDescription(string activitydescription)
        {
            if (string.IsNullOrWhiteSpace(activitydescription))
            {
                throw new ArgumentException("Activity description cannot be empty.");
            }
            ActivityDescription = activitydescription;
        }

        public void SetEducatorName(string firstname, string lastname)
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException("Educator first name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                throw new ArgumentException("Educator last name cannot be empty.");
            }
            EducatorFirstName = firstname;
            EducatorLastName = lastname;
        }

        public void SetField(string field)
        {
            if (string.IsNullOrWhiteSpace(field))
            {
                throw new ArgumentException("Field cannot be empty.");
            }
            Field = field;
        }

        public void SetCalculatedHours(float calculatedhours)
        {
            if (calculatedhours < 0)
            {
                throw new ArgumentException("Calculated hours cannot be negative.");
            }
            CalculatedHours = calculatedhours;
        }

        public void SetActivityCategory(String category)
        {
            ActivityCategory = category;
        }
    }
}
namespace BlazorTest.Components.Classes
{
    public class Activity
    {
        public DateTime ActivityDate { get; private set; }
        public string ActivityName { get; private set; } = string.Empty;
        public float ActivityHours { get; private set; } = 0f;
        public EducationCategory? ActivityCategory { get; private set; } = null;
        public string ActivityDescription { get; private set; } = string.Empty;
        public string EducatorFirstName { get; private set; } = string.Empty;
        public string EducatorLastName { get; private set; } = string.Empty;

        public string TopicTitle { get; set; } = string.Empty;


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
            ActivityHours = activityhours;
        }

        public void SetActivityCategory(EducationCategory activitycategory)
        {
            if (activitycategory == null)
            {
                throw new ArgumentNullException(nameof(activitycategory), "Activity category cannot be null.");
            }
            ActivityCategory = activitycategory;
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

    }
}

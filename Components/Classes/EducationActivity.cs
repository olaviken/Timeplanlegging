namespace BlazorTest.Components.Classes
{
    public class EducationActivity
    {
        public DateTime ActivityDate { get; private set; }
        public string ActivityName { get; private set; } = string.Empty;
        public float ActivityHours { get; private set; } = 0f;
        public EducationCategory? ActivityCategory { get; private set; } = null;
        public string ActivityDescription { get; private set; } = string.Empty;
        public string EducatorFirstName { get; private set; } = string.Empty;
        public string EducatorLastName { get; private set; } = string.Empty;


    }
}

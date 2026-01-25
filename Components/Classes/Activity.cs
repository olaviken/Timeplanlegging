using BlazorTest.Components.Classes.Interfaces;
using BlazorTest.Components.Classes.Lists;

namespace BlazorTest.Components.Classes
{
    public class Activity
    {
        public string ActivityID { get; set; } = Guid.NewGuid().ToString();
        public DateTime ActivityDate { get; set; }
        public string ActivityName { get; set; } = string.Empty;
        public float ActivityHours { get; set; } = 0f;

        public float CalculatedHours { get; set; } = 0f;
        public string ActivityCategory { get; set; } = string.Empty;
        public string SubjectCode { get; set; } = string.Empty;
        public string FieldTitle { get; set; } = string.Empty;

        public string ActivityDescription { get; set; } = string.Empty;
        public string EducatorFullName { get; set; } = string.Empty;

    }
}
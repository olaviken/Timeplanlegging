using BlazorTest.Components.Classes.Interfaces;
using BlazorTest.Components.Classes.Lists;
using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Components.Classes
{
    public class Activity
    {
        public string ActivityID { get; set; } = Guid.NewGuid().ToString();

        [Required(ErrorMessage = "Activity date is required.")]
        public DateTime ActivityDate { get; set; }

        [Required(ErrorMessage = "Activity name is required.")]
        public string ActivityName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Activity hours are required.")]
        public float ActivityHours { get; set; } = 0f;

        public float CalculatedHours { get; set; } = 0f;
        public string ActivityCategory { get; set; } = string.Empty;

        [Required(ErrorMessage = "Subject code is required.")]
        public string SubjectCode { get; set; } = string.Empty;
        public string FieldTitle { get; set; } = string.Empty;

        public string ActivityDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Educator full name is required.")]
        public string EducatorFullName { get; set; } = string.Empty;

    }
}
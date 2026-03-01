using System.ComponentModel.DataAnnotations;


namespace BlazorTest.Components.Classes
{
    public class EducationCategory
    {
        [Required(ErrorMessage ="Category name is required")]
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Hours multiplier is required")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Hours multiplier must be greater than 0")]
        public float HoursMultiplier { get; set; } = 1;

    }  
}

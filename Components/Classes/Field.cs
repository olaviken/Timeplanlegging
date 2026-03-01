using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Components.Classes
{
    public class Field
    {
        [Required(ErrorMessage = "Field ID is required.")]
        public string FieldID { get; set; } = string.Empty;
        [Required(ErrorMessage = "Field Type is required.")]
        public string FieldTitle { get; set; } = string.Empty;
        public string FieldDescription { get; set; } = string.Empty;
                        
    }
}

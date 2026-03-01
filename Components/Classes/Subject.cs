using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Components.Classes
{
    public class Subject
    {
        [Required(ErrorMessage = "Subject code is required.")]
        public string SubjectCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Subject name is required.")]
        public string SubjectName { get; set; }= string.Empty;
        public string SubjectDescription { get; set; }= string.Empty;
    }
}

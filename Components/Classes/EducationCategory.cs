namespace BlazorTest.Components.Classes
{
    public class EducationCategory
    {
        public string CategoryName { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public float HoursMultiplier { get; private set; } = 1f;

        public EducationCategory(string categoryname, string description, int hoursmultiplier)
        {
            if(string.IsNullOrWhiteSpace(categoryname))
            {
                throw new ArgumentException("Category name cannot be empty.");
            }
            if(string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description cannot be empty.");
            }
            if(hoursmultiplier <= 0)
            {
                throw new ArgumentException("Hours multiplier must be greater than zero.");
            }
            CategoryName = categoryname;
            Description = description;
            HoursMultiplier = hoursmultiplier;
        }
    }  
}

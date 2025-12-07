namespace BlazorTest.Components.Classes
{
    public class EducationCategory
    {
        public string CategoryName { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public int HoursMultiplier { get; private set; } = 1;

        public EducationCategory(string categoryname, string description, int hoursmultiplier)
        {
            setCategoryName(categoryname);
            setDescription(description);
            setHoursMultiplier(hoursmultiplier);
        }

        public void setCategoryName(string categoryname)
        {
            if (string.IsNullOrWhiteSpace(categoryname))
            {
                throw new ArgumentException("Category name cannot be empty.");
            }
            CategoryName = categoryname;
        }

        public void setDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description cannot be empty.");
            }
            Description = description;
        }

        public void setHoursMultiplier(int hoursmultiplier)
        {
            if (hoursmultiplier <= 0)
            {
                throw new ArgumentException("Hours multiplier must be greater than zero.");
            }
            HoursMultiplier = hoursmultiplier;
        }
    }  
}

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
        public string ActivityDescription { get; set; } = string.Empty;
        public string EducatorFullName { get; set; } = string.Empty;
        

        public float CalculateHours(float hours, string category, ICategories categories)//Virker ikke. kanskje flytte den til selve siden
        {
            float calculatedHours = 0f;
            
            if(this.CalculatedHours > 0)
            {
                calculatedHours = this.CalculatedHours;
            }
            if(this.CalculatedHours == 0)
            {
                float multiplier = 1.0f;
                EducationCategory? foundCategory = categories.FindCategory(category);
                if (foundCategory != null)
                {
                    multiplier = foundCategory.HoursMultiplier;
                }
                calculatedHours = hours * multiplier;
            }
            this.CalculatedHours = calculatedHours;
            return this.CalculatedHours;                        
        }

    }
}
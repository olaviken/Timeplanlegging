using System.Data.Common;

namespace BlazorTest.Components.Classes
{

    public class EducatorList
    {
        public List<Educator> Educators { get; private set; } = new List<Educator>();

        public float TotalHoursForEducation
        {
            get
            {
                float totalHours = 0;
                foreach (var educator in Educators)
                {
                    if (educator.HoursForEducation>=0)
                    {
                        totalHours += educator.HoursForEducation;
                    }
                }

                return totalHours;
            }
        }

        public float TotalHoursForRND
        {
            get
            {
                float totalHours = 0;
                foreach (var educator in Educators)
                {
                    if (educator.HoursForRND>=0)
                    {
                        totalHours += educator.HoursForRND;
                    }
                }
                return totalHours;
            }
        }

        public EducatorList() { }
        public void AddEducator(Educator educator)
        {
            if (educator == null)
            {
                throw new ArgumentNullException(nameof(educator), "Educator cannot be null.");
            }
            Educators.Add(educator);
        }
        
        public void RemoveEducator(Educator educator)
        {
            if (educator == null)
            {
                throw new ArgumentNullException(nameof(educator), "Educator cannot be null.");
            }
            Educators.Remove(educator);
        }

        public Educator? FindEducatorByEmail(string email)
        {
            return Educators.FirstOrDefault(e => e.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateEducator(Educator updatedEducator)
        {
            if (updatedEducator == null)
            {
                throw new ArgumentNullException(nameof(updatedEducator), "Updated educator cannot be null.");
            }
            var existingEducator = FindEducatorByEmail(updatedEducator.Email);
            if (existingEducator != null)
            {
                int index = Educators.IndexOf(existingEducator);
                Educators[index] = updatedEducator;
            }
            else
            {
                throw new InvalidOperationException("Educator not found.");
            }
        }

    }
        
}

using System.Data.Common;

namespace BlazorTest.Components.Classes
{

    public class EducatorList
    {
        public List<Educator> Educators { get; private set; } = new();

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
            if (FindEducatorByEmail(educator.Email) != null)
            {
                throw new InvalidOperationException("An educator with the same email already exists.");
            }
            Educators.Add(educator);
        }
        
        public void RemoveEducator(Educator educator)
        {
            if (educator == null)
            {
                throw new ArgumentNullException(nameof(educator), "Educator cannot be null.");
            }
            if(Educators == null || Educators.Count == 0)
            {
                throw new InvalidOperationException("Educator list is empty.");
            }
            Educators.Remove(educator);
        }

        public Educator? FindEducatorByEmail(string email)
        {
            Educator? result = null;
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email), "Email cannot be null.");
            }
            if (Educators == null || Educators.Count == 0)
            {
                throw new InvalidOperationException("Educator list is empty.");
            }
            if (Educators.Any(e => e.Email == email))
            {
                result = Educators.First(e => e.Email == email);
                return result;
            }
            else
            {
                throw new InvalidOperationException("Educator with the specified email not found.");

            }
        }

        public Educator? FindEducatorByName(string fullname)
        {
            if (fullname == null)
            {
                throw new ArgumentNullException(nameof(fullname), "Full name cannot be null.");
            }
            if (Educators == null || Educators.Count == 0)
            {
                throw new InvalidOperationException("Educator list is empty.");
            }
            if (Educators.Any(e => $"{e.LastName}, {e.FirstName}".Equals(fullname, StringComparison.OrdinalIgnoreCase)) == false)
            {
                throw new InvalidOperationException("Educator with the specified name not found.");
            }
            else
            {
                return Educators.First(e => $"{e.LastName}, {e.FirstName}".Equals(fullname, StringComparison.OrdinalIgnoreCase));
            }
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

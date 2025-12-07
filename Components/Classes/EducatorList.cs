
namespace BlazorTest.Components.Classes
{
    public class EducatorList
    {
        // keep internal list private and expose a read-only view
        public List<Educator> educatorsList = new();    

        
        public EducatorList() { }

        public void AddEducator(Educator educator)
        {
            if (educator is null) throw new ArgumentNullException(nameof(educator));
            if (educatorsList.Any(e => string.Equals(e.Email, educator.Email, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("An educator with the same email already exists.");
            educatorsList.Add(educator);
        }

        // return bool to indicate whether removal succeeded (caller can decide to throw)
        public void RemoveEducator(Educator educator)
        {
            educatorsList.Remove(educator);
        }

        public Educator? FindEducatorByEmail(string email)
        {
            return educatorsList.FirstOrDefault(e => string.Equals(e.Email, email, StringComparison.OrdinalIgnoreCase));
        }

        public Educator? FindEducatorByName(string fullname)
        {
            return educatorsList.FirstOrDefault(e =>
                string.Equals($"{e.LastName}, {e.FirstName}", fullname, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateEducator(Educator updatedEducator)
        {
            var existing = FindEducatorByEmail(updatedEducator.Email);
            int index = educatorsList.IndexOf(existing);
            educatorsList[index] = updatedEducator;
        }

        public int Count => educatorsList.Count;
    }
}

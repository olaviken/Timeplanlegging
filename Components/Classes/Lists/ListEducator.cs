using BlazorTest.Components.Classes.Interfaces;

namespace BlazorTest.Components.Classes.Lists
{
    public class ListEducator : IEducators
    {
        // keep internal list private and expose a read-only view
        private List<Educator> listEducators = new();    

        public List<Educator> GetEducators()
        {
            return listEducators;
        }

        public ListEducator() { }

        public void AddEducator(Educator educator)
        {
            if (educator is null) throw new ArgumentNullException(nameof(educator));
            if (listEducators.Any(e => string.Equals(e.Email, educator.Email, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("An educator with the same email already exists.");
            listEducators.Add(educator);
        }

        public void RemoveEducator(Educator educator)
        {
            listEducators.Remove(educator);
        }

        public Educator? FindEducatorByEmail(string email)
        {
            return listEducators.FirstOrDefault(e => string.Equals(e.Email, email, StringComparison.OrdinalIgnoreCase));
        }

        public Educator? FindEducatorByName(string fullname)
        {
            return listEducators.FirstOrDefault(e =>
                string.Equals($"{e.LastName}, {e.FirstName}", fullname, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateEducator(Educator updatedEducator)
        {
            var existing = FindEducatorByEmail(updatedEducator.Email);
            int index = listEducators.IndexOf(existing);
            listEducators[index] = updatedEducator;
        }

        public int CountEducators()
        {
            return listEducators.Count;
        }
    }
}

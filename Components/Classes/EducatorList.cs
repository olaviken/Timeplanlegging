using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorTest.Components.Classes
{
    public class EducatorList
    {
        // keep internal list private and expose a read-only view
        private readonly List<Educator> _educators = new();
        public IReadOnlyList<Educator> Educators => _educators;

        
        public EducatorList() { }

        public void AddEducator(Educator educator)
        {
            if (educator is null) throw new ArgumentNullException(nameof(educator));
            if (_educators.Any(e => string.Equals(e.Email, educator.Email, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("An educator with the same email already exists.");
            _educators.Add(educator);
        }

        // return bool to indicate whether removal succeeded (caller can decide to throw)
        public bool RemoveEducator(Educator educator)
        {
            if (educator is null) throw new ArgumentNullException(nameof(educator));
            return _educators.Remove(educator);
        }

        public Educator? FindEducatorByEmail(string email)
        {
            if (email is null) throw new ArgumentNullException(nameof(email));
            return _educators.FirstOrDefault(e => string.Equals(e.Email, email, StringComparison.OrdinalIgnoreCase));
        }

        public Educator? FindEducatorByName(string fullname)
        {
            if (fullname is null) throw new ArgumentNullException(nameof(fullname));
            return _educators.FirstOrDefault(e =>
                string.Equals($"{e.LastName}, {e.FirstName}", fullname, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateEducator(Educator updatedEducator)
        {
            if (updatedEducator is null) throw new ArgumentNullException(nameof(updatedEducator));
            var existing = FindEducatorByEmail(updatedEducator.Email);
            if (existing is null) throw new InvalidOperationException("Educator not found.");
            int index = _educators.IndexOf(existing);
            _educators[index] = updatedEducator;
        }
    }
}

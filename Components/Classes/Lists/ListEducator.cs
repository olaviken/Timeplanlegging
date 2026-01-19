using BlazorTest.Components.Classes.Interfaces;

namespace BlazorTest.Components.Classes.Lists
{
    public class ListEducator : IEducators
    {
        // keep internal list private and expose a read-only view
        private List<Educator> listEducators = new List<Educator> {

            new Educator
            {
                FirstName = "Peder",
                LastName = "Aas",
                Email = "peder@ntnu.no",
                Education = "Sykepleie",
                Specialization = "Anestesi",
                BirthDate = new DateTime(1980, 5, 15),
                PercentagePosition = 100,
                PercentageRND = 20
            },

            new Educator {
                FirstName = "Kari",
                LastName = "Olsen",
                Email = "kari@ntnu.no",
                Education = "Fysioterapi",
                Specialization = "Bevegelsesfag",
                BirthDate = new DateTime(1975, 8, 22),
                PercentagePosition = 80,
                PercentageRND = 15
                },
            new Educator {
                FirstName = "Lars",
                LastName = "Hansen",
                Email = "lars@ntnu.no",
                Education = "Ergoterapi",
                Specialization = "Aktivitet og deltakelse",
                BirthDate = new DateTime(1970, 3, 10),
                PercentagePosition = 60,
                PercentageRND = 20
            }


            };  

        public List<Educator> GetEducators()
        {
            return listEducators;
        }
               
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

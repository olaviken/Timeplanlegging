namespace BlazorTest.Components.Classes.Lists
{
    using BlazorTest.Components.Classes.Interfaces;
    using System.Collections.Generic;

    public class ListCategoryTest : ICategories
    {
        private List<EducationCategory> listCategoires = new List<EducationCategory>
        {
            new EducationCategory
                {
                    CategoryName = "Undervisning",
                    Description = "Arbeid knyttet til forelesning og gruppeundervisning",
                    HoursMultiplier = 4
                },
                new EducationCategory
                {
                    CategoryName = "Veiledning",
                    Description = "Arbeid knyttet til veiledning av studenter",
                    HoursMultiplier = 5
                },
                new EducationCategory
                {
                    CategoryName = "Eksamen",
                    Description = "Arbeid knyttet til eksamensgjennomføring og vurdering",
                    HoursMultiplier = 3
                },
                new EducationCategory
                {
                    CategoryName = "Praksisarbeid",
                    Description = "Arbeid knyttet til gjennomføring av praksis",
                    HoursMultiplier = 6
                },
        };

        public List<EducationCategory> GetCategories()
        {
            return listCategoires;
        }

        public void AddCategory(EducationCategory category)
        {
            listCategoires.Add(category);
        }

        public int CountCategories()
        {
            return listCategoires.Count;
        }

        public EducationCategory? FindCategory(string categoryname)
        {
            if (listCategoires.Any(c => c.CategoryName == categoryname))
            {
                var foundCategory = listCategoires.First(c => c.CategoryName == categoryname);
                var result = new EducationCategory();
                return result;
            }
            return null;
        }



        public void RemoveCategory(EducationCategory category)
        {
            listCategoires.Remove(category);
        }

        public void UpdateCategory(EducationCategory updatedCategory)
        {
            var existingCategory = listCategoires.FirstOrDefault(c => c.CategoryName == updatedCategory.CategoryName);
            if (existingCategory != null)
            {
                int index = listCategoires.IndexOf(existingCategory);
                listCategoires[index] = updatedCategory;
            }
        }
    }
}

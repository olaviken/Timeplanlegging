namespace BlazorTest.Components.Classes
{
    public class ListCategory
    {
        public List<EducationCategory> EducationCategories { get; private set; } = new();

        public ListCategory() { }

        public void AddCategory(EducationCategory category)
        {
            EducationCategories.Add(category);
        }

        public ListCategory FindCategory(string categoryname)
        {
            
            if (EducationCategories.Any(c => c.CategoryName == categoryname))
            {
                var foundCategory = EducationCategories.First(c => c.CategoryName == categoryname);
                var result = new ListCategory();
                result.AddCategory(foundCategory);
                return result;
            }
            return null;
        }

        public void RemoveCategory(EducationCategory category)
        {
            EducationCategories.Remove(category);
        }

        public void UpdateCategory(EducationCategory updatedCategory)
        {
            var existingCategory = EducationCategories.FirstOrDefault(c => c.CategoryName == updatedCategory.CategoryName);
            if (existingCategory != null)
            {
                int index = EducationCategories.IndexOf(existingCategory);
                EducationCategories[index] = updatedCategory;
            }
        }

        

        public int Count => EducationCategories.Count;

    }
}

namespace BlazorTest.Components.Classes
{
    public class CategoryList
    {
        public List<EducationCategory> EducationCategories { get; private set; } = new();

        public CategoryList() { }

        public void AddCategory(EducationCategory category)
        {
            EducationCategories.Add(category);
        }

        public CategoryList FindCategory(string categoryname)
        {
            
            if (EducationCategories.Any(c => c.CategoryName == categoryname))
            {
                var foundCategory = EducationCategories.First(c => c.CategoryName == categoryname);
                var result = new CategoryList();
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

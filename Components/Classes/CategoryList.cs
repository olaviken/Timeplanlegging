namespace BlazorTest.Components.Classes
{
    public class CategoryList
    {
        public List<EducationCategory> EducationCategories { get; private set; } = new();

        public CategoryList() { }

        public void AddCategory(EducationCategory category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category cannot be null.");
            }
            if (EducationCategories.Any(c => c.CategoryName == category.CategoryName))
            {
                throw new InvalidOperationException($"Category with name '{category.CategoryName}' already exists.");
            }
            EducationCategories.Add(category);
        }

        public CategoryList FindCategory(string categoryname)
        {
            if (string.IsNullOrWhiteSpace(categoryname))
            {
                throw new ArgumentException("Category name cannot be null or empty.", nameof(categoryname));
            }
            if(EducationCategories == null || !EducationCategories.Any())
            {
                throw new InvalidOperationException("No categories available to search.");
            }
            if (EducationCategories.Any(c => c.CategoryName == categoryname))
            {
                var foundCategory = EducationCategories.First(c => c.CategoryName == categoryname);
                var result = new CategoryList();
                result.AddCategory(foundCategory);
                return result;
            }
            else
            {
                throw new KeyNotFoundException($"Category with name '{categoryname}' not found.");
            }
        }

        public void RemoveCategory(EducationCategory category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category cannot be null.");
            }
            if (EducationCategories == null || EducationCategories.Count ==0)
            {
                throw new InvalidOperationException("No categories available to remove.");
            }
        }


    }
}

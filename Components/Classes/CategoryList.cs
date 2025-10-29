namespace BlazorTest.Components.Classes
{
    public class CategoryList
    {
        public List<EducatioCategory> EducationCategories { get; private set; } = new();

        public CategoryList() { }

        public void AddCategory(EducatioCategory category)
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
    }
}

using BlazorTest.Components.Classes.Interfaces;

namespace BlazorTest.Components.Classes.Lists
{
    public class ListCategory : ICategories
    {
        private List<EducationCategory> listCategoires = new();

        public List<EducationCategory> GetEducationCategories()
        {
            return listCategoires;
        }

        public ListCategory() { }

        public void AddCategory(EducationCategory category)
        {
            listCategoires.Add(category);
        }

        public ListCategory FindCategory(string categoryname)
        {
            
            if (listCategoires.Any(c => c.CategoryName == categoryname))
            {
                var foundCategory = listCategoires.First(c => c.CategoryName == categoryname);
                var result = new ListCategory();
                result.AddCategory(foundCategory);
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

        

        public int CountCategories()
        {
            return listCategoires.Count;
        }

        EducationCategory? ICategories.FindCategory(string categoryname)
        {
            throw new NotImplementedException();
        }
    }
}

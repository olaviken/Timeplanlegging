namespace BlazorTest.Components.Classes.Interfaces
{
    public interface ICategories
    {
        List<EducationCategory> GetCategories();
        void AddCategory(EducationCategory category);
        void RemoveCategory(EducationCategory category);
        EducationCategory FindCategory(string categoryname);
        void UpdateCategory(EducationCategory updatedCategory);
        int CountCategories();

    }
}

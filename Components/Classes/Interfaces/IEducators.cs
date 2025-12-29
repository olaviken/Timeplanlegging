namespace BlazorTest.Components.Classes.Interfaces
{
    public interface IEducators
    {
        List<Educator> GetEducators();
        void AddEducator(Educator educator);
        void RemoveEducator(Educator educator);
        Educator? FindEducatorByEmail(string email);

        EducationCategory? FindEducatorByName(string fullname);
        void UpdateEducator(Educator updatedEducator);

        int CountEducators();
    }
}

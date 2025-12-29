namespace BlazorTest.Components.Classes.Interfaces
{
    public interface ISubjects
    {
        List<Subject> GetSubjects();
        void AddSubject(Subject subject);
        void RemoveSubject(Subject subject);
        Subject? FindSubjectByCode(string subjectCode);
        void UpdateSubject(Subject updatedSubject);
        int CountSubjects();
    }
}

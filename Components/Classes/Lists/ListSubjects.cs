using BlazorTest.Components.Classes.Interfaces;

namespace BlazorTest.Components.Classes.Lists
{
    public class ListSubjects : ISubjects
    {
        private List<Subject> listSubjects = new();
        public List<Subject> GetSubjects()
        {
            return listSubjects;
        }
        public ListSubjects() { }
        public void AddSubject(Subject subject)
        {
            if (subject is null) throw new ArgumentNullException(nameof(subject));
            if (listSubjects.Any(s => string.Equals(s.SubjectCode, subject.SubjectCode, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("A subject with the same code already exists.");
            listSubjects.Add(subject);
        }
        public void RemoveSubject(Subject subject)
        {
            listSubjects.Remove(subject);
        }
        public Subject? FindSubjectByCode(string subjectCode)
        {
            return listSubjects.FirstOrDefault(s => string.Equals(s.SubjectCode, subjectCode, StringComparison.OrdinalIgnoreCase));
        }
        public void UpdateSubject(Subject updatedSubject)
        {
            var existing = FindSubjectByCode(updatedSubject.SubjectCode);
            int index = listSubjects.IndexOf(existing);
            listSubjects[index] = updatedSubject;
        }
        public int CountSubjects()
        {
            return listSubjects.Count;
        }
    }
}

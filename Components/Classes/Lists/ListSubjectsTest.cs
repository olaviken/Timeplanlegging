namespace BlazorTest.Components.Classes.Lists
{
    using BlazorTest.Components.Classes.Interfaces;
    using System.Collections.Generic;

    public class ListSubjectsTest : ISubjects
    {
        private List<Subject> listSubjects = new List<Subject>
        {
            new Subject
            {
                SubjectCode = "SYK1000",
                SubjectName = "Introduksjon til sykepleie",
                SubjectDescription = "Grunnleggende prinsipper og praksis innen sykepleie"
            },
            new Subject
            {
                SubjectCode = "FYS1000",
                SubjectName = "Grunnleggende Anatomi og fysiologi",
                SubjectDescription = "Studie av menneskekroppens struktur og funksjon"
            },
            new Subject
            {
                SubjectCode = "ERGO3000",
                SubjectName = "Ergoterapi i praksis",
                SubjectDescription = "Praktisk anvendelse av ergoterapi i ulike settinger"
            },
            new Subject
            {
                SubjectCode = "RAD4000",
                SubjectName = "Radiografiteknikker",
                SubjectDescription = "Teknikker og metoder innen medisinsk bildediagnostikk"
            },
            new Subject
            {
                SubjectCode = "AMB5000",
                SubjectName = "Prehospital akuttmedisin",
                SubjectDescription = "Akuttmedisinsk behandling og omsorg i prehospitale settinger"
            },
            new Subject
            {
                SubjectCode = "HEL6000",
                SubjectName = "Helseadministrasjon og ledelse",
                SubjectDescription = "Ledelse og administrasjon i helsesektoren"
            },
            new Subject
            {
                SubjectCode = "SAM7000",
                SubjectName = "Samfunnsmedisin og folkehelse",
                SubjectDescription = "Studie av helse på befolkningsnivå og forebyggende tiltak"
            },

        };
        public void AddSubject(Subject subject)
        {
            if (subject is null) throw new ArgumentNullException(nameof(subject));
            if (listSubjects.Any(s => string.Equals(s.SubjectCode, subject.SubjectCode, StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException("A subject with the same code already exists.");
            listSubjects.Add(subject);
        }

        public int CountSubjects()
        {
            return listSubjects.Count;
        }

        public Subject? FindSubjectByCode(string subjectCode)
        {
            return listSubjects.FirstOrDefault(s => string.Equals(s.SubjectCode, subjectCode, StringComparison.OrdinalIgnoreCase));
        }

        public List<Subject> GetSubjects()
        {
            return listSubjects;
        }

        public void RemoveSubject(Subject subject)
        {
            listSubjects.Remove(subject);
        }

        public void UpdateSubject(Subject updatedSubject)
        {
            var existing = FindSubjectByCode(updatedSubject.SubjectCode);
            int index = listSubjects.IndexOf(existing);
            listSubjects[index] = updatedSubject;
        }
    }
}

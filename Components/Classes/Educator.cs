using System;

namespace BlazorTest.Components.Classes
{
    class Educator
    {
        public string FirstName { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; } = string.Empty;
        public string Position { get; private set; } = string.Empty;
        public string SubjectUnit { get; private set; } = string.Empty;
        public string Education { get; private set; } = string.Empty;
        public string Specialization { get; private set; } = string.Empty;

        public string UserName { get; private set; } = string.Empty;
        public int Age { get; private set; }
        public int HoursForEducation { get; private set; }
    }
}

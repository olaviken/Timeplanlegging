using BlazorTest.Components.Classes;

namespace BlazorTest.Components.Services
{
    public class SelectedSubjectService
    {
        public Subject? Current { get; private set; }
        public event Action? OnChanged;
        public void Set(Subject subject)
        {
            Current = subject;
            OnChanged?.Invoke();
        }
    }
}

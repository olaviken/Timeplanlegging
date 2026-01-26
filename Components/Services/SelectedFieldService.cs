using System;
using BlazorTest.Components.Classes;


namespace BlazorTest.Components.Services
{
    
    public class SelectedFieldService
    {
        public Field? Current { get; private set; }
        public event Action? OnChanged;

        public void Set(Field field)
        {
            Current = field;
            OnChanged?.Invoke();
        }
    }
}

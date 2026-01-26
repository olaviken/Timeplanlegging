using System;
using BlazorTest.Components.Classes;

namespace BlazorTest.Components.Services
{
    public class SelectedEducatorService
    {
        public Educator? Current { get; private set; }
        public event Action? OnChanged;

        public void Set(Educator educator)
        {
            Current = educator;
            OnChanged?.Invoke();
        }
    }
}
using BlazorTest.Components.Classes;


namespace BlazorTest.Components.Classes.Interfaces
{
    public interface IActivityEditorService
    {
        Activity Current { get; }

        void Reset();
        void StartEdit(Activity activity);
        void AddOrUpdate();
        void Delete(Activity activity);

        void UpdateCalculatedHours(float multiplier);


    }
}

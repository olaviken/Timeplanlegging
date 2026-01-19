namespace BlazorTest.Components.Classes.Interfaces
{
    public interface IActivities
    {
        List<Activity> GetActivities();
        void AddActivity(Activity activity);
        void RemoveActivity(Activity activity);
        Activity? FindActivityByID(string activityID);
        void UpdateActivity(Activity updatedActivity);
        int CountActivities();
    }
}

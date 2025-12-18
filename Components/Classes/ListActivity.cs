namespace BlazorTest.Components.Classes
{
    public class ListActivity : IActivites
    {
        private List<Activity> listActivities = new();

        public List<Activity> GetActivities()
        {
            return listActivities;
        }

        public ListActivity() { }

        public void AddActivity(Activity activity)
        {
            listActivities.Add(activity);
        }



        public void RemoveActivity(Activity activity)
        {
            listActivities.Remove(activity);
        }

        public void UpdateActivity(Activity updatedActivity)
        {
            var existingActivity = listActivities.FirstOrDefault(a => a.ActivityName == updatedActivity.ActivityName && a.ActivityDate == updatedActivity.ActivityDate);
            if (existingActivity != null)
            {
                int index = listActivities.IndexOf(existingActivity);
                listActivities[index] = updatedActivity;
            }
        }

        public Activity? FindActivityByID(string activityID)
        {
            return listActivities.FirstOrDefault(a => a.ActivityID == activityID);
        }
        

        public int CountActivities()
        {
            return listActivities.Count;
        }
    }
}

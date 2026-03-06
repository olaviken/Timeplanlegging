using BlazorTest.Components.Classes;
using BlazorTest.Components.Classes.Interfaces;

namespace BlazorTest.Components.Services
{
    public class ActivityEditorServices : IActivityEditorService
    {
        private readonly IActivities _activities;

        public Activity Current { get; private set; }

        public ActivityEditorServices(IActivities activities)
        {
            _activities = activities;
            Current = new Activity { ActivityDate = DateTime.Today };
        }

        public void Reset()
        {
            Current = new Activity{ActivityDate = DateTime.Today};
        }

        public void StartEdit(Activity activity)
        {
            if (activity != null) Current = activity;
        }


        public void AddOrUpdate()
        {
            if (Current == null) return;
            if((!string.IsNullOrEmpty(Current.ActivityID)) && (_activities.FindActivityByID(Current.ActivityID) != null))
            {
                _activities.UpdateActivity(Current);

            }
            else 
            {
                _activities.AddActivity(Current);
            }
            Reset();

        }
        public void Delete(Activity activity)
        {
            if(activity != null)    
            {
                _activities.RemoveActivity(activity);
            }
        }

        public void UpdateCalculatedHours(float multiplier)
        {
            if(Current != null)
            {
                Current.CalculatedHours = Current.ActivityHours * multiplier;
            }
        }
    }
}
//Test comment to trigger commit
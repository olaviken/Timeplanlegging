namespace BlazorTest.Components.Services
{
    public class DateService
    {
        public DateTime SchoolYearStartDate { get; set; }
        public DateTime SchoolYearEndDate { get; set; }


        public event Action? OnDatesChanged;

        public void SetStartDate(DateTime startDate)
        {
            SchoolYearStartDate = startDate;
            OnDatesChanged?.Invoke();
        }

        public void SetEndDate(DateTime endDate)
        {
            SchoolYearEndDate = endDate;
            OnDatesChanged?.Invoke();


        }

        public void CalculateStartDate()
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            if (currentMonth > 6) //using end of June as the cutoff for the school year, so if it's July or later, we are in the new school year
            {
                this.SchoolYearStartDate = new DateTime(currentYear, 8, 1);
            }
            else
            {
                this.SchoolYearStartDate = new DateTime(currentYear - 1, 8, 1);
            }
        }

        public void CalculateEndDate()
        {
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            if (currentMonth > 6) //using end of June as the cutoff for the school year, so if it's July or later, we are in the new school year
            {
                this.SchoolYearEndDate = new DateTime(currentYear + 1, 6, 30);
            }
            else
            {
                this.SchoolYearEndDate = new DateTime(currentYear, 6, 30);
            }

        }
    }
}

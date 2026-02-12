using System.Xml.Serialization;

namespace BlazorTest.Components.Services
{
    public class DateService
    {
        public DateTime SchoolYearStartDate { get; set; }
        public DateTime SchoolYearEndDate { get; set; }

        public  DateTime MiddleSchoolYearDate { get; private set; }
        


        public DateService()
        {            CalculateSchoolYearDates();        }        private void CalculateSchoolYearDates()        {            int currentYear = DateTime.Now.Year;            int currentMonth = DateTime.Now.Month;            if (currentMonth > 6) // Assuming school year starts in August            {                SchoolYearStartDate = new DateTime(currentYear, 8, 1);                MiddleSchoolYearDate = new DateTime(currentYear, 12, 31);                SchoolYearEndDate = new DateTime(currentYear + 1, 6, 30);            }            else            {                SchoolYearStartDate = new DateTime(currentYear - 1, 8, 1);                MiddleSchoolYearDate = new DateTime(currentYear - 1, 12, 31);                SchoolYearEndDate = new DateTime(currentYear, 6, 30);            }                                }        public void SetSchoolYearDates(DateTime start, DateTime end)        {            SchoolYearStartDate = start;            SchoolYearEndDate = end;                        MiddleSchoolYearDate = new DateTime(start.Year,12,31);        }            }}

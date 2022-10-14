using System;

namespace Question3
{
    public class AttendanceInfo
    {
        public DateTime Date { get; set; }
        public int NumberOfWorkedHour { get; set; }
        public AttendanceInfo(DateTime date,int numberOfWorkedHour)
        {
            Date=date;
            NumberOfWorkedHour=numberOfWorkedHour;
        }
    }
}

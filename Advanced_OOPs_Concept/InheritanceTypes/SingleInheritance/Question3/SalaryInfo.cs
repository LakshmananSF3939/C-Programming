using System;

namespace Question3
{
    public class SalaryInfo:AttendanceInfo
    {
        public int SalaryOfMonth { get; set; }
        public string Month { get; set; }
        public SalaryInfo(DateTime date,int numberOfWorkedHour,int salary,string month):base( date, numberOfWorkedHour)
        {
           SalaryOfMonth=salary;
           Month=month;
        }
    }
}

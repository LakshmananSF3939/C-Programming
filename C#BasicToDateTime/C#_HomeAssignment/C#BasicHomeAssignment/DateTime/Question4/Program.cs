using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter DateTime:");
            DateTime dateTime=new DateTime(2016,11,7);
            System.Console.WriteLine($"The day of the week {dateTime.ToShortDateString()} is {dateTime.DayOfWeek}");

        }
    }
}

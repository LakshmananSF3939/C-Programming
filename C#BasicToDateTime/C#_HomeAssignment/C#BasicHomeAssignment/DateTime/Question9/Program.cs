 using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter dateTime1:");
            DateTime datetime1=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
            System.Console.WriteLine("Enter dateTime1:");
            DateTime datetime2=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
            for(int i=datetime1.Year;i<=datetime2.Year;i++)
            {
                if(DateTime.IsLeapYear(i))
                {
                    DateTime date1=new DateTime(i,2,29);
                    DateTime date2=date1.AddYears(1);
                    System.Console.WriteLine($"Is leap year {i}");
                    System.Console.WriteLine($"One year from {date1.ToShortDateString()} to {date2.ToShortDateString()}");
                }
            }
        }
    }
}

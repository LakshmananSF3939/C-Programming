using System;
namespace Question3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("enter a datetime:");
           DateTime dateTime=new DateTime(2016,8,16,3,57,32);
           System.Console.WriteLine("Year:"+dateTime.Year); 
           System.Console.WriteLine("Month:"+dateTime.Month);
           System.Console.WriteLine("Date:"+dateTime.Day);
           System.Console.WriteLine("Hour:"+dateTime.Hour);
           System.Console.WriteLine("Minute:"+dateTime.Minute);
           System.Console.WriteLine("Seconds:"+dateTime.Second);
           System.Console.WriteLine("Milli Seconds:"+dateTime.Millisecond);
        }
    } 
}

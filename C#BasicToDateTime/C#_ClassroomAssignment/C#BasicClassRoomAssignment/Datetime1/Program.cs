using System;
namespace Datetime1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            DateTime date1=new DateTime(2021,08,10,10,40,32);
            System.Console.WriteLine("Day:"+date1.Day);
            System.Console.WriteLine("Month:"+date1.Month);
            System.Console.WriteLine("Year:"+date1.Year);
            System.Console.WriteLine("Hour:"+date1.Hour);
            System.Console.WriteLine("Minute:"+date1.Minute);
            System.Console.WriteLine("Seconds:"+date1.Second);
           string date2=date1.ToString();
          System.Console.WriteLine(date2);
          string[] s=date2.Split('/',' ',':');
          foreach( string i in s)
          {
             System.Console.WriteLine(i) ;
          }
        
        }
    }
}

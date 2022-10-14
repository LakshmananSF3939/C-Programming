using System;
namespace System 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter year:");
            DateTime dateTime=new DateTime();
            dateTime=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            for(int i=0;i<=10;i++)
            {
                DateTime datedisplay=dateTime.AddYears(i);
                System.Console.WriteLine($"{datedisplay.ToString("dd/MM/yyyy")}: day {datedisplay.DayOfYear} of {datedisplay.Year}");
            }
        }
    }
}

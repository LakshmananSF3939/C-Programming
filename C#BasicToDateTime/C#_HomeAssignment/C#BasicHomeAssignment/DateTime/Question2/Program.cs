using System;
namespace Question2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter DateTime input:");
            //DateTime dateTime=DateTime.Parse(Console.ReadLine());
            DateTime dateTime=new DateTime(2022,4,28,11,49,5);
            System.Console.WriteLine("COMplete Date:"+dateTime.ToString("dd/MM/yyyy HH/mm/ss tt"));
            System.Console.WriteLine("Short Date:"+dateTime.ToShortDateString());
            System.Console.WriteLine("Long Date:"+dateTime.ToLongDateString());
            System.Console.WriteLine("12 hours:"+dateTime.ToString("dd/MM/yyyy hh/mm/ss tt"));
            System.Console.WriteLine("Date only:"+dateTime.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Time only:"+dateTime.ToString("HH/mm/ss tt"));
        }
    }
}
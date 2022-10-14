using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter DateTime:");
            DateTime[] dateTime={DateTime.Now,new DateTime(2016,8,16,9,28,0 ),new DateTime(2011, 5, 28, 10, 35, 0),new DateTime(1979, 12, 25, 14, 30, 0) };
            for(int i=0;i<dateTime.Length;i++)
            {
                System.Console.WriteLine($"Day:{dateTime[i].ToString("dd/MM/yyyy HH:mm:ss tt")}\nDay:{dateTime[i].ToString("dd/MM/yyyy hh:mm:ss tt")}");
            }
        }
    }
}
 
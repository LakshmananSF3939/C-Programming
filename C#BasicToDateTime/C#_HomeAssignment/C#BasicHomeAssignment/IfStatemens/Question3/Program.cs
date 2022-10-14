using System;
namespace Question3
 {
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a year:");
            int year=Convert.ToInt32(Console.ReadLine());
            if( year%4==0 && year%100!=0 || year%400==0)
            {
                
                System.Console.WriteLine("Leap year");
            }
            
            else
            {
                System.Console.WriteLine("Not a leap year");
            }
        }
    }
 }



using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Inches:");
            double inches=double.Parse(Console.ReadLine());
            double centiMeter=inches*2.54;
            System.Console.WriteLine($"Inches in Centimeter:{centiMeter}");
        }
    }
}

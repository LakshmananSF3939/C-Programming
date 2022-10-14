using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Celcius:");
            double celcius=double.Parse(Console.ReadLine());
            double fahrenheit=Math.Round((celcius*9/5+32),2);
            System.Console.WriteLine($"Fahrenheit:{fahrenheit}");

        }
    }
}

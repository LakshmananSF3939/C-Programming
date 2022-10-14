using System;
namespace Question9 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter speed and time:");
            int speed=int.Parse(Console.ReadLine());
            int time=int.Parse(Console.ReadLine());
            int distancetravelled = speed*time* 5/18;
            System.Console.WriteLine($"DistanceTraveled:{distancetravelled}");

        }
    }
}

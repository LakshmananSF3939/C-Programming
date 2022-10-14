using System;
namespace Question4 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double radius=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            double height=Convert.ToDouble(Console.ReadLine());
            double volume=3.14*radius*radius*height;
            Console.WriteLine($"Volume:{volume}");
        }
    }
}

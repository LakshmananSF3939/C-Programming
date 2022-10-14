using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter Radius of Circle:"); 
           double radius=double.Parse(Console.ReadLine());
           double area=3.14*radius*radius;
           double perimeter=2*3.14*radius;
           System.Console.WriteLine($"Area:{area}\nPerimeter:{perimeter}");
        }
    }
}

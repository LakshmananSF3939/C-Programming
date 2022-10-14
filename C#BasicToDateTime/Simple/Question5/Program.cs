using System;
namespace Question5 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter basic salary:");
            double salary=double.Parse(Console.ReadLine());
            double da=(salary+10)/100;
            double hra=(salary+10)/100;
            double tax=double.Parse(Console.ReadLine())/100;
            System.Console.WriteLine($"Total:{salary+(salary+da+hra)*tax}");
        }
    }
}

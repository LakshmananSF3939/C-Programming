using System;
namespace Question13 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Mathematical table number:");
            int number=int.Parse(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                System.Console.WriteLine($"{number}*{i}={number*i}");
            }
        }
    }
}

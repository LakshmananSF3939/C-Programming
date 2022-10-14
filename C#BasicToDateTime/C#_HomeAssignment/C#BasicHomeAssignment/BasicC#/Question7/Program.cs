using System;
namespace Question7 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int a=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter b:");
            int b=Convert.ToInt32(Console.ReadLine());
            int output =(a+b)*(a+b);
            Console.WriteLine($"Output:{output}");
        }
    }
}

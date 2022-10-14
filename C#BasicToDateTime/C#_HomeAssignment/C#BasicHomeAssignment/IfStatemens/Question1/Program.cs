using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a integer number:");
            int number=Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                System.Console.WriteLine($"{number} is a even integer");
            }
            else
            {
                System.Console.WriteLine($"{number} is an Odd integer");
            }
        }
    }
}

using System;
namespace Question6 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number:");
            int number=int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Factorial is {number}! is {Fact(number)}");
            int Fact(int n)
            {
                if(n==1)
                {
                    return 1;
                }
                else
                {
                    return n*Fact(n-1);
                }
            }
        }
    }
}

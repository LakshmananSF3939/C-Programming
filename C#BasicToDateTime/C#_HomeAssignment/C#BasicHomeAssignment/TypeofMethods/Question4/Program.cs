using System;
namespace Question4 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter how many terms of fibonacci sequence:");
            int limit=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Fibonacci series:");
            Fibonacci(limit);
            void Fibonacci(int limit)
            {
                int a=-1;
                int b=1;
                int c;
                for(int i=0;i<limit;i++)
                {
                   c=a+b;
                   System.Console.Write(c+" ");
                   a=b;
                   b=c;
                }
            }
        }
    }
}

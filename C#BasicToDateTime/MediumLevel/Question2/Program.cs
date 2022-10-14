using System;
namespace Question2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter limit:");
            int limit=int.Parse(Console.ReadLine());
            int a=-1;
            int b=1;
            int c;
            System.Console.WriteLine($"Here is the fibonacci series upto {limit} :");
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

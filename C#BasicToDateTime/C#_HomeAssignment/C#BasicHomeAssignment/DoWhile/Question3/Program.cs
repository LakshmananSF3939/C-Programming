using System;
namespace Question3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
          int a=-1;
          int b=1;
          int c;
          int i=1;
          System.Console.WriteLine("Enter Limit:");
          int limit=Convert.ToInt32(Console.ReadLine());
          System.Console.WriteLine("Fibonacci Number:");
          do
          {
             c=a+b;
             System.Console.Write(c+" ");
             a=b;
             b=c;
             i++;
          }  while(limit>=i);
        }
    }
}

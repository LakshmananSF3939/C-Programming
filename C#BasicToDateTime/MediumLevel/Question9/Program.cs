using System;
namespace Question9 
{
    class Program 
    {
        public static void Main(string[] args)
        {
             System.Console.WriteLine("Enter limit:");
             int limit=int.Parse(Console.ReadLine());
             for(int i=0;i<limit;i++)
             {
                for(int s=0;s<limit-i-1;s++)
                  System.Console.Write("  ");
                for(int j=0;j<2*i+1;j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
             }
        }
    }
}

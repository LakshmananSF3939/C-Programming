using System;
namespace Question10 
{
    class Program 
    {
        public static void Main(string[] args)
        {
          System.Console.WriteLine("Enter the value of N:");
          int N=int.Parse(Console.ReadLine());
          System.Console.WriteLine($"Leap year from 1 to {N}");
          for(int i=1;i<=N;i++)
          {
              if(i%400==0)
              {
                System.Console.Write(i+" ");
              }
              else if(i%100==0)
              {
                continue;
              } 
              else if(i%4==0)
              {
                System.Console.Write(i+" ");
              }
          }  
        }
    }
}

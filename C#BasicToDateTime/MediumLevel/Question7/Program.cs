using System;
namespace Question7 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a starting number :");
            int startingNumber=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter limits ");
            int limit=int.Parse(Console.ReadLine());
            int sum=0;
            int series=startingNumber;
            System.Console.WriteLine("Output series:");
            for(int i=0;i<limit;i++)
            {
              
              System.Console.Write(series+" ");
              sum+=series;
              series+=2;
                 
            }
            System.Console.WriteLine("\nSum:"+sum);
        }
    }
}

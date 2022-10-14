using System;
namespace Question3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter limit");
            int limit=int.Parse(Console.ReadLine());
            int[] numbers=new int[limit];
            int i;
            int sum=0;
            System.Console.WriteLine("Enter elements:");
            for(i=0;i<limit;i++)
            {
              numbers[i]=int.Parse(Console.ReadLine());
            }
            for(i=0;i<limit;i++)
            {
               sum=sum+numbers[i]; 
            }
            System.Console.WriteLine($"Sum of the all elements:{sum}");
        }
    }
}

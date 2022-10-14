using System;
namespace Question11 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter base value:");
           int baseValue=int.Parse(Console.ReadLine());
           System.Console.WriteLine("Enter power value:");
           int power=int.Parse(Console.ReadLine());
           int sum=1;
           for(int i=0;i<power;i++)
           {
              sum*=baseValue;
           } 
           System.Console.WriteLine("X Power y:"+sum);
        }
    }
}

using System;
namespace Question10 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter limit:");
           int limit=int.Parse(Console.ReadLine());
           for(int i=0;i<limit;i++)
           {
            for(int j=0;j<3*limit;j++)
            {   
                if(i==0||j==0||i==limit-1||j==3*limit-1)
                System.Console.Write("*");
                else
                System.Console.Write(" ");
            }
            System.Console.WriteLine();
           } 
        }
    }
}

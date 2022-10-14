using System;
namespace Question20 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter limit:");
            int n=int.Parse(Console.ReadLine());
            int l;
             for(int i=-n;i<n;i++)
             {
                if(i<0)
                {
                  l=-i;
                }
                else
                {
                    l=i;
                }
                for(int s=0;s<l;s++)
                System.Console.Write(" ");
                for(int j=0;j<n-l;j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
             }
        }
    }
}

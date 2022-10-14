using System;
namespace Question21 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter limit:");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<=n;i++)
            {
                for(int s=0;s<=n-i-1;s++)
                System.Console.Write("  ");  
                for(int j=0;j<2*i+1;j++)
                {
                    if(i==j)
                    {
                        System.Console.Write("| ");
                    }
                    else
                    {
                        System.Console.Write("* ");
                    }
                } 
                System.Console.WriteLine();             
            }
        }
    }
}

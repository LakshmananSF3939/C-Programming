using System;
namespace Question6 
{
    class Prograom 
    {
        public static void Main(string[] args)
        {
             int n=5;
            for(int i=0;i<n;i++)
            {
                for(int s=0;s<n-i-1;s++)
                   System.Console.Write(" ");
                for(int j=0;j<i+1;j++)
                {
                    Console.Write("* ");
                }
                 
                Console.WriteLine();
            }
        }
    }
}

using System;
namespace Question6 
{
    class Prograom 
    {
        public static void Main(string[] args)
        {
             int n=5;
             int k=1;
            for(int i=0;i<n;i++)
            {
                for(int s=0;s<n-i-1;s++)
                   System.Console.Write(" ");
                for(int j=0;j<i+1;j++)
                { if(k>0 && k<=9)
                    Console.Write($"{k++} ");
                    else
                    System.Console.Write($"{k++}");
                }
                 
                Console.WriteLine();
            }
        }
    }
}


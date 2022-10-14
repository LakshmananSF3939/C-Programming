using System;
namespace Question2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter limit:");
            int n=int.Parse(Console.ReadLine());
            int[] a=new int[n];
            System.Console.WriteLine("Enter elements:");
            for(int i=0;i<n;i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            for(int i=n-1;i>=0;i--)
            {
                System.Console.WriteLine(a[i]);
            }
        }
    }
}

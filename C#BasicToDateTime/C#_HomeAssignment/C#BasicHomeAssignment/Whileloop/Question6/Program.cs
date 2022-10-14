using System;
namespace Question6 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Print 1-100 even numbers:");
            int i=1;
            while(i<=100)
            {
                if(i%2==0)
                System.Console.Write(i+" ");
                i++;
            }
            i=1;
            System.Console.WriteLine("\nPrint 1-100 Odd numbers:");
            while(i<=100)
            {
                if(i%2==1)
                System.Console.Write(i+" ");
                i++;
            }
            System.Console.WriteLine("Prime numbers range 1-100");
            i=2;
            while(i<=100)
            {
                int j=2;
                while(j<=i)
                {
                 if(i==j)
                {
                    System.Console.Write(i+" ");
                }
                if(i%j==0)
                {
                    break;
                }
                j++;
                }
                i++;
            }
        }
    }
}

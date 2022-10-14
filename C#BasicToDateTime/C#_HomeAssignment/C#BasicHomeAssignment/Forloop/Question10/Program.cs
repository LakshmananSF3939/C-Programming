using System;
namespace Question10 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int n=Convert.ToInt32(Console.ReadLine());
            int f=0;
            for(int i=2;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    f=1;
                    break;
                }
            }
            if(f==0)
            System.Console.WriteLine("Prime number");
            else
            System.Console.WriteLine("Not a prime");
        }
    }
}

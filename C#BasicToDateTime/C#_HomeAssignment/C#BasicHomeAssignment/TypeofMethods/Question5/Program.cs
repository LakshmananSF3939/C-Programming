using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number:");
            int number=int.Parse(Console.ReadLine());
            int flag=Prime(number);
            if(flag==0)
            {
                 System.Console.WriteLine("Prime Number");
            }
            else 
            {
                System.Console.WriteLine("Not a prime number");
            }
            int Prime(int n)
            {
                int f=0;
                for(int i=2;i<n/2;i++)
                {
                    if(n%i==0)
                    {
                        f=1;
                    }
                }
                return f;
            }
        }
    }
}

using System;
namespace Question15 
{
    class Program 
    {
        public static void Main(string[] args)
        {
             System.Console.WriteLine("Enter a number");
            int number=Convert.ToInt32(Console.ReadLine());
            int flag=0;
            for(int i=2;i<=number/2;i++)
            {
                if(number%i==0)
                {
                    flag=1;
                    break;
                }
            }
            if(flag==0)
            System.Console.WriteLine("Prime number");
            else
            System.Console.WriteLine("Not a prime");
        }
    }
}

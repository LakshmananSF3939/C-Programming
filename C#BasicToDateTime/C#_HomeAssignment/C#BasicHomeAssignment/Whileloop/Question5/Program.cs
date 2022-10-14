using System;
namespace Question5 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number:");
            int no=Convert.ToInt32(Console.ReadLine());
            
            int sum=0;
            while(no!=0)
            {
              sum=sum+no%10;
              no/=10;
            }
            System.Console.WriteLine(sum);
        }
        

    }
}

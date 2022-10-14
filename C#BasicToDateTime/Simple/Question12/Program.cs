using System;
namespace Question11 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Sum of the Square of odd numbers in range (1-99)");
            int sum=0;
            int range=int.Parse(Console.ReadLine());
            
            for(int i=1;i<=range;i++)
            {
                if(i%2==1)
                {
                     sum=sum+i*i;
                }
              
            }
            System.Console.WriteLine("Sum of the Square of odd numbers in range (1-99):"+sum);
        }
    }
}

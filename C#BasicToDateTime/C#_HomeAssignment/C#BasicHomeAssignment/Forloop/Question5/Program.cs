using System;
namespace Question5 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter limit:");
            int limit=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            int j=1;
            for(int i=1;i<=limit;i++)
            {
                System.Console.WriteLine(j);
                sum=sum+j;
                j=j+2;
                
            }
            System.Console.WriteLine(sum);
        }
    }
}

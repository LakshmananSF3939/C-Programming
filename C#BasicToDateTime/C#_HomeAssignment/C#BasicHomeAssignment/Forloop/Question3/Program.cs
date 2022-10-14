using System;
namespace Question3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter input:");
            int n=Convert.ToInt32(Console.ReadLine());
            int j=0;
            for(int i=1;i<=n;i++)
            {
              j=i*i*i;
              System.Console.WriteLine($"Number is : {i} and cube of the {i} is :{j}");
            }
        }
    }
}

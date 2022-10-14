using System;
namespace Question4 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter table no:");
            int table=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                System.Console.WriteLine($"{table}*{i}={table*i}");
            }
        }
    }
}

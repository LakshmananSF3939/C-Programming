using System;
namespace Question4 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");
            int no1=Convert.ToInt32(Console.ReadLine());
            int no2=Convert.ToInt32(Console.ReadLine());
            int no3=Convert.ToInt32(Console.ReadLine());
            if (no1>no2 && no1>no3)
            {
                System.Console.WriteLine("1st number is the greatest amoung number");
            }
            if (no2>no1 && no2>no3)
            {
                System.Console.WriteLine("2st number is the greatest amoung number");
            }
            if (no3>no1 && no3>no1)
            {
                System.Console.WriteLine("3st number is the greatest amoung number");
            }

        }
    }
}

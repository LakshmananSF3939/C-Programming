using System;
namespace Question8 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter sugar level:");
            int sugarlevel=Convert.ToInt32(Console.ReadLine());
            if(sugarlevel<90)
            {
                System.Console.WriteLine("Low sugar");
            }
            else if(sugarlevel>=90 && sugarlevel<130)
            {
                System.Console.WriteLine("Normal ");
            }
            else if(sugarlevel>=130 && sugarlevel<140)
            {
                System.Console.WriteLine("Medium");
            }
            else if(sugarlevel>=140 && sugarlevel<170)
            {
                System.Console.WriteLine("High-try to reduce is from now");
            }
            else
            {
                System.Console.WriteLine("You are a very higher sugar patient");
            }
        }
    }
}

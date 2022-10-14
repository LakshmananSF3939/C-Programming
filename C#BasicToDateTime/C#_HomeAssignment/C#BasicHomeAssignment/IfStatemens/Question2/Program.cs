using System;
namespace Question2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Age:");
            int age=Convert.ToInt32(Console.ReadLine());
            if(age>=21)
            {
                System.Console.WriteLine("Congratulation! You are eligible for casting your vote.");

            }
            else
            {
                System.Console.WriteLine("Your not eligible");
            }
        }
    }
}

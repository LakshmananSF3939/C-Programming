using System;
namespace Question10 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Password");
            string Password=Console.ReadLine();
            if(Password=="HiTeam")
            {
                System.Console.WriteLine("right password");
            }
            else
            System.Console.WriteLine("wrong password");
        }
    }
}
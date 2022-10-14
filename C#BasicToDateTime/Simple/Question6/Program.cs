using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter password:");
            string password=Console.ReadLine();
            if(password=="s3cr3t!p@ssw0rd")
            {
                System.Console.WriteLine("Welcome");
            }
            else
            {
                System.Console.WriteLine("Wrong Password");
            }
        }
    }
}

using System;
namespace Question9 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string str=Console.ReadLine();
            System.Console.WriteLine("Enter a Substring:");
            string subString=Console.ReadLine();
            bool temp=str.Contains(subString);
            if(temp)
            {
                System.Console.WriteLine("The substring is exists is a string");
            }
            else
            {
                System.Console.WriteLine("Not present");
            }
        }
    }
}

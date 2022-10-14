using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string;");
            string str=Console.ReadLine();
            string str1="";
            for(int i=str.Length-1;i>=0;i--)
            {
                str1+=str[i];
            }
            if(str==str1)
            {
                System.Console.WriteLine($"{str1} is a Palindrome");
            }
            else
            {
                System.Console.WriteLine("Not a palindrome");
            }
        }
    }
}

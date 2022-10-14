using System;
namespace Question4 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string");
            string words=Console.ReadLine();
            System.Console.WriteLine("The number word in the string:");
            string[] word=words.Split(' ');
            int c=0;
            foreach(string i in word)
            {
               c++;
            }
            System.Console.WriteLine(c);
        }
    }
}

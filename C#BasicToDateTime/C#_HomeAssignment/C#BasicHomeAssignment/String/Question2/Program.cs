using System;
namespace Question2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter String:");
            string word =Console.ReadLine();
            System.Console.WriteLine("The Charecter of the string are:");
            foreach(char i in word)
            {
                System.Console.Write(i+" ");
        }
    }
}
}

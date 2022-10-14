using System;
namespace Quetion3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string word =Console.ReadLine();
            int length=word.Length;
            System.Console.WriteLine("The individual charecters in reverse order:");
            for(int i=length-1;i>=0;i--)
            {
               System.Console.Write(word[i]+" ");
            }
        }
    }
}

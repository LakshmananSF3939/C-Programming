using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string words=Console.ReadLine();
            int count=0;
            System.Console.WriteLine("Length:"+words.Length);
            foreach(char i in words)
            {
                count++;
            }
            System.Console.WriteLine("Length:"+count);
        }
    }
}

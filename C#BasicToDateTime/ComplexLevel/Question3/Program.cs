using System;
namespace Question3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter name1:");
            string nameOne=Console.ReadLine();
            System.Console.WriteLine("Enter name2:");
            string nameTwo=Console.ReadLine();
            int c=0;
            int length=nameOne.Length;
            for(int i=0;i<length;i++)
            {
                if(nameOne.Contains(nameTwo[i]))
                {
                    c++;
                }
            }
            System.Console.WriteLine(c);
            if(c==length)
            {
                System.Console.WriteLine("nameone and nametwo are Anagrams");
            }
            else
            {
                System.Console.WriteLine("Not Anagrams");
            }
        }
    }
}

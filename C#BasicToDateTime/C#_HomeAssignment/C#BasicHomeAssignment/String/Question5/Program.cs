using System;
namespace Question5 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string 1:");
            string str1=Console.ReadLine();
            System.Console.WriteLine("Enter string 2:");
            string str2=Console.ReadLine();
            int length1=str1.Length;
            int length2=str2.Length;
            
            if(length1==length2)
            {
                if(str1.Equals(str2))
                {
                    System.Console.WriteLine("String lengths are same and both are same string");
                }
                else
                {
                    System.Console.WriteLine("String lengths are same and not same string");
                }
            }
            else
            {
                System.Console.WriteLine("length is not equal");
            }
        }
    }
}

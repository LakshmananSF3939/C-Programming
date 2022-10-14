using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string str=Console.ReadLine();
            string str1="";
            
            foreach(char i in str)
            {
                if(!str1.Contains(i))
                {
                    str1+=i;
                }
            }
            System.Console.Write(str1);    
        }
    }
         
}

using System;

namespace Question11 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("enter A string:");
           string str=Console.ReadLine();
          string str1="";
          for(int i=0;i<str.Length;i++)
          {
            if(!str1.Contains(str[i]))
            {
                str1+=str[i];
            }
          }
          System.Console.WriteLine(str1); 
        }
        
    }
}

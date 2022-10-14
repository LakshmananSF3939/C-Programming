using System;
namespace String 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a String:");
           string mainString= Console.ReadLine();
           System.Console.WriteLine("Enter a substring:");
           string subString=Console.ReadLine();
           string string1=mainString.Replace(subString,"@");
           int count=0;
            foreach(char c in string1.ToCharArray())
            {
              if(c=='@')
               {
                count++;
               }
            
           }
           System.Console.WriteLine("Count:"+count);
        }
    }
}


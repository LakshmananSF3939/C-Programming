using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("ENter String:");
            string str=Console.ReadLine();
            IsPolindrome(str);
            void IsPolindrome(string str)
            {
                int i;
                
                string str1="";
                for(i=str.Length-1;i>=0;i--)
                {
                    str1+=str[i];
                  
                }
                if(str==str1)
                {
                    System.Console.WriteLine("Polindrome");
                }
                else
                {
                    System.Console.WriteLine("not a polindrome");
                }

            }
        }
    }
}

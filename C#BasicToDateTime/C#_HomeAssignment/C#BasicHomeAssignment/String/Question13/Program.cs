using System;
namespace Question13 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string str=Console.ReadLine();
            int sum=0;
            for(int i=0;i<str.Length;i++)
            {
               
                if(str[i]>='0' && str[i]<='9')
                {
                   sum+=str[i]-48; 
                }
            }
            System.Console.WriteLine("Total:"+sum);
        }
    }
}

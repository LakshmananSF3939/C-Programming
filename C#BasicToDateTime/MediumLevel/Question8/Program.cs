using System;
namespace Question8 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string str=Console.ReadLine();
            string str1="";
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='0' && str[i]<='9')
                {
                    str1+=str[i];
                }
            } 
            int n=str1.Length;
            System.Console.WriteLine(str1);
            int f=0;
            for(int i=0;i<str1.Length;i++)
            {
                if(i==n-1 && (str1[i]==50||str1[i]==52||str1[i]==54||str1[i]==56||str1[i]==48))
                 {
                    f=1;
                 }
            }
            if(f==1)
            System.Console.WriteLine("Even number");
            else
            {
                System.Console.WriteLine("Odd number");
            }
        }
    }
}

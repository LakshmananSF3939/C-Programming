using System;
namespace Question12 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string str=Console.ReadLine();
            int[] number=new int[100];
            int c=0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]!=' ')
                {
                    number[c++]=str[i]-48;
                }
            }
           
           int max=0;
           int min=999;
             for(int i=0;i<c;i++)
            {
               if(max<number[i])
               {
                max=number[i];
               }
               if(min>number[i])
               {
                min=number[i];
               }
            }
            System.Console.WriteLine($"Maximum Value:{max}\nMinimum value:{min}");
        }
    }
}

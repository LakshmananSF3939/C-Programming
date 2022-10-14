using System;
namespace Quetion1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int a=-1;
            int b=1;
            int i=1;
            int c;
            while(i<=10)
            {
              c=a+b;
              System.Console.Write(c+" ");
              a=b;
              b=c;
              i++;
              
            }
           
         }
        }
    }


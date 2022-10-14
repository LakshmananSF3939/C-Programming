using System;
namespace Quetion1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int no;
            string condition="";
            do 
            {
              System.Console.WriteLine("user input:");
               no=Convert.ToInt32(Console.ReadLine());
             if(no%2==0)
             {
                System.Console.WriteLine("Even Number");
             } 
             else
             {
                System.Console.WriteLine("Odd Number");
             } 
             System.Console.WriteLine("Again need to check Odd or Even number:");
             condition=Console.ReadLine().ToLower();
             while(condition!="yes" && condition!="no")
             {
                System.Console.WriteLine("The input is wrong and please give valid input");
                condition=Console.ReadLine().ToLower();
                break;
             }
              

            }while(condition=="yes");
        }
    }
}

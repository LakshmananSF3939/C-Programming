using System;
namespace Question3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter any number:");
            
           int number=int.Parse(Console.ReadLine());
           int number1=number;
           int temp=0;
           while(number!=0)
           {
               temp=temp*10+number%10;
               number/=10;
           }
            if(number1==temp)
            {
                System.Console.WriteLine($"{number1} is a palindrome number");
            }
            else
            {
                System.Console.WriteLine("Not a palindrome");
            }
            
            
        }
    }
}
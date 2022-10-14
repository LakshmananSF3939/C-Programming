using System;
namespace SwitchStatement 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number 1:");
            double number1=Convert.ToInt32(Console.ReadLine());
             System.Console.WriteLine("Enter number 2:");
            double number2=Convert.ToInt32(Console.ReadLine());
           System.Console.WriteLine("Enter arithmetic operator:");
           char choice=Convert.ToChar(Console.ReadLine());
           switch(choice)
           {
               case '+':
              {
                 System.Console.WriteLine($"Result {number1+number2}");
                  break;   
               }   
               case '-':
              {
                 System.Console.WriteLine($"Result {number1-number2}");
                  break;   
               }   
               case '*':
              {
                 System.Console.WriteLine($"Result {number1*number2}");
                  break;   
               }   
               case '/':
              {
                 System.Console.WriteLine($"Result {number1/number2}");
                  break;   
               }   
               case '%':
              {
                 System.Console.WriteLine($"Result {number1%number2}");
                  break;   
               } 
               default:
               {
                System.Console.WriteLine("Invalid operation");
                break;
               }        
           }
           
           
           

        }
    }
}

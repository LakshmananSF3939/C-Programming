using System;
namespace Question4 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter number:");
           int number;
           bool temp=int.TryParse(Console.ReadLine(),out number);
           while(!temp || number>6)
           {
            System.Console.WriteLine("Wrong numberb! Enter a valid number:");
            temp=int.TryParse(Console.ReadLine(),out number);
             

           }
           if(number>0 && number<=5)
           {
            System.Console.WriteLine("Valid number");
           }
        }
    }
}
using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number1:");
            double number1=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter number2:");
            double number2=int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Addition{Addition:(number1,number2)}\nSubtraction:{Subtraction(number1,number2)}\nMultiplication:{Multiplication(number1,number2)}\nDivision:{Division(number1,number2)}");
            double Addition(double x,double y)
            {
                double additon=x+y;
                return additon;
            }
            double Subtraction(double x,double y)
            {
                double subtract=x-y;
                return subtract;
            }
            double Multiplication(double x,double y)
            {
                double multiply=x*y;
                return multiply;
            } 
            double Division(double x,double y)
            {
                double division=x/y;
                return division;
            }
        }
    }
}
    


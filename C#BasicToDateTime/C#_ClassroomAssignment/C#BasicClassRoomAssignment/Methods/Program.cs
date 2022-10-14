using System;
namespace Methods 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            
            double number1;
            double number2;
            char choice;
            string condition;
            do 
            {
                System.Console.WriteLine("Enter number1:");
                 number1=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter number2:");
                 number2=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter Choice \naddition \n subtraction \n multiplication \n divion:");
                choice=char.Parse(Console.ReadLine());
                switch(choice)
                 {
                    case '+':
                    {
                        System.Console.WriteLine($"Addition:{Addition(number1,number2)}");
                        break;
                    }
                    case '-':
                    {
                        System.Console.WriteLine($"Subtraction:{Subtraction(number1,number2)}");
                        break;
                    }
                    case '*':
                    {
                        System.Console.WriteLine($"Multiplication:{Multiplication(number1,number2)}");
                        break;
                    }
                    case '/':
                    {
                        System.Console.WriteLine($"Division:{Division(number1,number2)}");
                        break;
                    }
                 }
                 System.Console.WriteLine("wheather you want continue say yes or no");
                condition=Console.ReadLine();
            }while(condition=="yes");
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

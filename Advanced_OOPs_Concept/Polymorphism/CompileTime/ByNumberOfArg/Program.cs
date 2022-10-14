using System;
namespace ByNumberOfArg;
class Program 
{
    public static void Main(string[] args)
    {
        
    }
    static void Display(int number)
    {
        System.Console.WriteLine("Argument "+number);
    }
    static void Display(int number1,int number2)
    {
        System.Console.WriteLine("Arguments: "+number1+"and "+number2);
    }
}


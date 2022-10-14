using System;
namespace FunctionDelgate;
class Program 
{
    static double Sum(int a,int b)
    {
        return a+b;
    }
    static double Subtract(int a,int b)
    {
        return a-b;
    }
    static double Calculator(Func<int , int , double>operaion ,int x,int y)
    {
        return operaion(x,y);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine(Calculator(Sum,10,15));
        System.Console.WriteLine(Calculator(Subtract,15,10));
    }
}

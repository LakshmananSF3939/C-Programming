using System;
namespace Deligates;
public delegate int Calculator(int i);//can add methods having int return type & 1 argument
class Program 
{
    static int value=10;
    public static int AddNum(int number)
    {
        value+=number;
        return value;
    }
    public static int MulNum(int number)
    {
        value*=number;
        return value;
    }
    public static int GetNum()
    {
        return value;
    }
    public static void Main(string[] args)
    {
        //create deligates instance
        Calculator nc1=new Calculator(AddNum);
        Calculator nc2=new Calculator(MulNum);
        //calling method using the deligates objects
        nc1(25);
        System.Console.WriteLine("Value of Number:{0}",GetNum());
        nc2(5);
        System.Console.WriteLine("Value of Number:{0}",GetNum());
    }
}
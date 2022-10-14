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
        Calculator nc;
        //create deligates instance
        Calculator nc1=new Calculator(AddNum);
        Calculator nc2=new Calculator(MulNum);
        //calling method using the deligates objects
        
        nc=nc1;
        nc+=nc2;

        nc(5);
        System.Console.WriteLine(GetNum());
    }
}
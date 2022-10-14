using System;
namespace OperatorOverLoading;
class Program 
{
    public static void Main(string[] args)
    {
        double volume;
        Box box1=new Box(11,16,15);
        volume=box1.Calculate();
        System.Console.WriteLine("Volume:"+volume);

        Box box2=new Box(13,12,15);
        box2.Calculate();
        System.Console.WriteLine("Volume:"+volume);
         
         Box box3;
         box3=box1+box2;
         volume=box3.Calculate();
         System.Console.WriteLine("Volume:"+volume);
    }
    
}


using System;
namespace Question10 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter two numbers:");
            int no1=int.Parse(Console.ReadLine());
            int no2=int.Parse(Console.ReadLine());
            System.Console.WriteLine(no1>no2);
            System.Console.WriteLine(no1<no2);
            System.Console.WriteLine(no1>=no2);
            System.Console.WriteLine(no1<=no2);
            System.Console.WriteLine(no1==no2);
            System.Console.WriteLine(no1!=no2);
            System.Console.WriteLine(no1>=10 && no2>=10);
            System.Console.WriteLine(no1>=10 || no2>=30);
            System.Console.WriteLine(!(no1>20));
            System.Console.WriteLine(no1++);
            System.Console.WriteLine(no1--);
            string value=no1==15?"true":"false";
            System.Console.WriteLine(value);

        }
    }
}
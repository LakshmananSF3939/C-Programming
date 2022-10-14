using System;
namespace Question3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter  number1:");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter  number2:");
            int number2=int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Before swap {number1} {number2}");
            Swap(number1,number2);
            
            void Swap(int value1,int value2)
            {
                int t;
                t=value1;
                value1=value2;
                value2=t;
                System.Console.WriteLine($"After swap {value1} {value2}");
        }
        }
    }
}

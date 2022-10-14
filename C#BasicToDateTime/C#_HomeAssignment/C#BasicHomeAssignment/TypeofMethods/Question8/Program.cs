using System;
namespace Question8 
{
    class Program 
    {
        public static void Main(string[] args)
        {
             System.Console.WriteLine("Enter mark1");
             double mark1=int.Parse(Console.ReadLine());
              System.Console.WriteLine("Enter mark2");
             double mark2=int.Parse(Console.ReadLine());
              System.Console.WriteLine("Enter mark3");
             double mark3=int.Parse(Console.ReadLine());
             double total=mark1+mark2+mark3;
             double percentage= Percentage(total);
             System.Console.WriteLine($"Mark1:{mark1}\nMark2:{mark2}\nMark3:{mark3}\nPercentage:{percentage}");
             double Percentage(double total)
             {
                double percentage=Math.Round(total/300*100);
                return percentage;
             }
        }
    }
}

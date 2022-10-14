using System;
namespace Question5 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Physics mark");
            int physics=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter chemistry mark");
            int chemistry=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter maths mark");
            int maths=int.Parse(Console.ReadLine());
            double total =physics+chemistry+maths;
            double percentage=Math.Round(total/300*100);
            if(percentage>=75)
            {
                System.Console.WriteLine("Eligible for admission");
            }
            else
            {
                System.Console.WriteLine("Not eligible");
            }
        }
    }
}

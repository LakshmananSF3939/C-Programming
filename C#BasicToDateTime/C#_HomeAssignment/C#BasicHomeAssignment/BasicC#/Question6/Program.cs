using System;
namespace Question6 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Price:");
            double price=Convert.ToDouble(Console.ReadLine());
            double total=price+price*0.18;
            Console.WriteLine($"Total:{total}");
        }
    }
}

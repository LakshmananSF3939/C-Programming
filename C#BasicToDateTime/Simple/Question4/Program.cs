using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter money in rupees:");
            double rate=double.Parse(Console.ReadLine());
            double usd=rate*0.0122;
            double eur=rate*0.0127;
            double cny=Math.Round((rate*0.0879),2);
            System.Console.WriteLine($"Rate:{rate}\nUSD:{usd}\nEUR:{eur}\nCNY:{cny}");
        }
    }
}

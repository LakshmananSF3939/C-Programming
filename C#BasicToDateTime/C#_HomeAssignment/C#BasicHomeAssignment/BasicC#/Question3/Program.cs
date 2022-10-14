using System;
namespace Ouestion3 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of celcius:");
            double celcius=Convert.ToDouble(Console.ReadLine());

            double kelvin=celcius+273;
            double fahrenheit=(celcius*9/5)+32;
            Console.WriteLine($"Kelvin:{kelvin}\nFahrenheit:{fahrenheit}");
        }
    }
}

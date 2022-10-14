using System;
namespace Question8 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter meter:");
            double meter=Convert.ToDouble(Console.ReadLine());
            double cm=meter*100;
            double 	mm = cm * 10;
            double inch=39.3*meter;
            double foot=12*meter;
            double mile=0.0006213715277778*meter;
           System.Console.WriteLine($"cm:{cm}\nmilli meter:{mm}\nInch:{inch}\nFoot:{foot}\nMile:{mile}");
            
        }
    }
}

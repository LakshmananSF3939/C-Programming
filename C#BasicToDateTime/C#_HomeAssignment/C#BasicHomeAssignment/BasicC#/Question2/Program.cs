using System;
namespace Question2 
{

    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first No:");
            int firstNo=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second No:");
            int secondNo=Convert.ToInt32(Console.ReadLine());

            double addition=firstNo+secondNo;
            double subtract=firstNo-secondNo;
            double multiply=firstNo*secondNo;
            double division=firstNo/secondNo;
            double modulas=firstNo%secondNo;

            Console.WriteLine($"{firstNo}+{secondNo}={addition}");
            Console.WriteLine($"{firstNo}-{secondNo}={subtract}");
            Console.WriteLine($"{firstNo}*{secondNo}={multiply}");
            Console.WriteLine($"{firstNo}/{secondNo}={division}");
            Console.WriteLine($"{firstNo}%{secondNo}={modulas}");

        }
    }
}

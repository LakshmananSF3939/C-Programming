using System;
namespace Question5 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Physics mark:");
            int physics=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry mark:");
            int chemistry=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maths mark:");
            int maths=Convert.ToInt32(Console.ReadLine());
            double sum=physics+chemistry+maths;
            double percentage=Math.Round(sum/300*100);
            Console.WriteLine($"Physics={physics}\nChemistry={chemistry}\nMaths={maths}\nSum={sum}\nPercentage={percentage}");
            Console.ReadLine();

        }
    }
}

using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int no=Convert.ToInt32(Console.ReadLine());
            int no1=Convert.ToInt32(Console.ReadLine());
            int no2=Convert.ToInt32(Console.ReadLine());
            switch(no)
            {
                case 1:
                {
                    System.Console.WriteLine($"Addition:{no1+no2}");
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine($"subtract:{no1+no2}");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine($"multiply:{no1*no2}");
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine($"division:{no1/no2}");
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Exit");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("invalid");
                    break;
                }
            }      
        }
    }
}

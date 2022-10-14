using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter choice 1-3");
            int choice=Convert.ToInt32(Console.ReadLine());
            int radius=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine($"Area:{3.14*radius*radius}");
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine($"circumberence:{2*3.14*radius}");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine($"Diametr:{2*radius}");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid");
                    break;
                }
            }
        }
    }
}

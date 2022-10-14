using System;
namespace Question2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number");
            int day=Convert.ToInt32(Console.ReadLine());
            switch(day)
            {
                case 1:
                {
                    System.Console.WriteLine("Monday");
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("tuesday");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("wednesday");
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("thursday");
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("friday");
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("saturday");
                    break;
                }
                case 7:
                {
                    System.Console.WriteLine("sunday");
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

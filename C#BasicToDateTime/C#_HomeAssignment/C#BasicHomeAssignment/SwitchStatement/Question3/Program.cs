using System;
namespace Question3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter month");
            int month=Convert.ToInt32(Console.ReadLine());
            switch(month)
            {
                case 1:
                {
                    System.Console.WriteLine("31 days");
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("28 days");
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("31 days");
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("30 days");
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("31 days");
                    break;
                }
                case 6:
                {
                    System.Console.WriteLine("30 days");
                    break;
                }
                case 7:
                {
                    System.Console.WriteLine("31 days");
                    break;
                }
                case 8:
                {
                    System.Console.WriteLine("30 days");
                    break;
                }
                case 9:
                {
                    System.Console.WriteLine("31 days");
                    break;
                }
                case 10:
                {
                    System.Console.WriteLine("30 days");
                    break;
                }
                case 11:
                {
                    System.Console.WriteLine("31 days");
                    break;
                }
                case 12:
                {
                    System.Console.WriteLine("31 days");
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

using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter temparature:");
            int temp=Convert.ToInt32(Console.ReadLine());
            if(temp<0)
            {
                System.Console.WriteLine("Freezing weather");
            }
            else if(temp>=0 && temp<10)
            {
                System.Console.WriteLine("Very cold weather");
            }
            else if(temp>=10 && temp<20)
            {
                System.Console.WriteLine("Cold weather");
            }
            else if(temp>=20 && temp<30)
            {
                System.Console.WriteLine("normal weather");
            }
            else if(temp>=30 && temp<40)
            {
                System.Console.WriteLine("hot weather");
            }
            else
            System.Console.WriteLine("Very hot weather");

        }
    }
}

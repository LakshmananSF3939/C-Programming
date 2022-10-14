using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter name of the month:");
            int month=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter leaves:");
            int leaves=int.Parse(Console.ReadLine());
            double salary;
            switch(month)
            {
                case 1:
                {
                  salary=(31-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 2:
                {
                  salary=(28-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 3:
                {
                  salary=(31-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 4:
                {
                  salary=(30-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 5:
                {
                  salary=(31-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 6:
                {
                  salary=(30-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 7:
                {
                  salary=(31-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 8:
                {
                  salary=(30-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 9:
                {
                  salary=(31-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 10:
                {
                  salary=(30-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 11:
                {
                  salary=(31-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
                 case 12:
                {
                  salary=(30-leaves)*500;
                  System.Console.WriteLine("Salary:"+salary);
                  break;
                }
            }

        }
    }
}

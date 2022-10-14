 using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Date time1:");
            DateTime date1=DateTime.Parse(Console.ReadLine());
             System.Console.WriteLine("Enter Date time2:");
              DateTime date2=DateTime.Parse(Console.ReadLine());
              int output=DateTime.Compare(date1,date2);
              if(output<0)
              {
                System.Console.WriteLine($"{output}:{date1} is Earlier than {date2}");
              }
              else if(output==0)
              {
                System.Console.WriteLine($"{output}:{date1} is same as {date2}");
              }
              else
              {
                System.Console.WriteLine($"{output}:{date1} is Later than {date2}");
              }
        }
    }
}

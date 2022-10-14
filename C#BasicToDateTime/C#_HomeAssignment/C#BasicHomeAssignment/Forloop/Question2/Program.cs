using System;
namespace Question2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            double sum=0;
            for(int i=1;i<=10;i++)
            {
               sum=sum+i;
            }
            double average=(sum/10);
            System.Console.WriteLine($"Sum:{sum}\nAverage:{average}");
        }
    }
}

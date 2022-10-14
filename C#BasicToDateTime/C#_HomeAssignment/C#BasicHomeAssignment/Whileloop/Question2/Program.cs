using System;
namespace Quetion1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int i=1;
            int sum=0;
            int count=Convert.ToInt32(System.Console.ReadLine());
            while(i<=count)
            {
                System.Console.Write($"{i} ");
                sum=sum+i*i;
                i++;
            }
            System.Console.WriteLine(sum);
        }
    }
}

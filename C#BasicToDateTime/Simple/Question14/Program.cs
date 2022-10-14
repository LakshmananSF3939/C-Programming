using System;
namespace Question14 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter value:");
            int n=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Output:");
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<i+1;j++)
                {
                    System.Console.Write(i+1+" ");
                }
                System.Console.WriteLine();
            }
        }
    }
}

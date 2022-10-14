using System;
namespace Question6 
{
    class Program 
    {
        public static void Main(string[] args)
        {
             System.Console.WriteLine("Enter limit:");
            int n=int.Parse(Console.ReadLine());
            int[] numbers=new int[n];
            System.Console.WriteLine("Enter elements:");
            for(int i=0;i<n;i++)
            {
            System.Console.WriteLine("Enter Element"+i);
            numbers[i]=int.Parse(Console.ReadLine());
            } 
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if(numbers[i]>numbers[j])
                    {
                        int t=numbers[i];
                        numbers[i]=numbers[j];
                        numbers[j]=t;
                    }
                }
                
            }
            System.Console.WriteLine("Ascending order:");
            for(int i=0;i<n;i++)
            {
                System.Console.Write(numbers[i]+" ");
            }
        }
    }
}

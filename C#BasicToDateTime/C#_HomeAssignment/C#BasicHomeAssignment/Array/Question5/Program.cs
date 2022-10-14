using System;
namespace Question5 
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
            int[] odd=new int[100];
            int[] even=new int[100];
            int c=0;
            int d=0;
            for(int i=0;i<n;i++)
            {
                if(numbers[i]%2==0)
                {
                    even[c++]=numbers[i];
                }
                else
                {
                    odd[d++]=numbers[i];
                }
            }
            System.Console.WriteLine("Even numbers:");
            for(int i=0;i<c;i++)
            {
                System.Console.Write(even[i]+" ");
            }
            System.Console.WriteLine("\nOdd numbers:");
            for(int i=0;i<d;i++)
            {
                System.Console.Write(odd[i]+" ");
            }
        }
    }
}

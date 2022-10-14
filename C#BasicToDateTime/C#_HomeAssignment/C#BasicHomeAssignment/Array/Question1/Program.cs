using System;
namespace Question1 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter limit:");
            int n=int.Parse(Console.ReadLine());
            int[] nums=new int[n];
            System.Console.WriteLine("Enter elements:");
            for(int i=0;i<n;i++)
            {
                nums[i]=int.Parse(Console.ReadLine());
            }
            foreach(int l in nums)
            {
              System.Console.WriteLine(l);
            }
        }
    }
}

using System;
namespace Question4 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter limit");
            int limit=int.Parse(Console.ReadLine());
            int[] numbers=new int[limit];
            int i;
            System.Console.WriteLine("Enter elements:");
            for(i=0;i<limit;i++)
            {
              numbers[i]=int.Parse(Console.ReadLine());
            }
            int max=0;
            int min=999;
            for(i=0;i<limit;i++)
            {
               if(max<numbers[i])
               {
                max=numbers[i];
               }
               if(min>numbers[i])
               {
                min=numbers[i];
               }
            }
            System.Console.WriteLine(max+" "+min);
        }
    }
}

using System;
namespace Question6 
{
    class Prograom 
    {
        public static void Main(string[] args)
        {
           
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<i+1;j++)
                {
                    Console.Write("* ");
                }
                 
                Console.WriteLine();
            }
        }
    }
}

using System;
namespace Question2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int no;
            int sum=0;
            do 
            {
                Console.WriteLine("Enter a number");
                no=Convert.ToInt32(Console.ReadLine());
                if(no>0)
                {
                   sum+=no;
                }
            }while(no>0);
            System.Console.WriteLine(sum);
        }
    }
}

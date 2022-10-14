using System;
namespace Forloop 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            for(int i=0;i<=25;i++)
            {
                if(i>0 && i%2==0)
                {
                 System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("Enter initial number:");
            int initialNo=Convert.ToInt32(Console.ReadLine());
             System.Console.WriteLine("Enter final number:");
            int finalNo=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for(int i=initialNo;i<=finalNo;i++)
            {
              int j=i*i;
              sum=sum+j;
              
            }
            System.Console.WriteLine(sum);
        }
    }
}

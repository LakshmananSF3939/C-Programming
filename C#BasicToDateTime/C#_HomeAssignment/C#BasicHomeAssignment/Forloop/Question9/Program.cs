using System;
namespace Question 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           int n=Convert.ToInt32(Console.ReadLine());
           int c=0;
           int temp=n;
           int t=n;
           while(n!=0)
           {
             n/=10;
             c++;
           }
           int sum=0;
           while(temp!=0)
           {
            int m=1;
            int a=temp%10;
            for(int i=0;i<c;i++)
              m=m*a;
              sum=sum+m;
              temp/=10;
           }
           if(sum==t)
           System.Console.WriteLine("Armstrong number"); 
           else
           System.Console.WriteLine("Not armstrong");
           
        }
    }
}
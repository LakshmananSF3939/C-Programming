using System;
namespace Question2 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            double a=1;
            double b=2;
            double c=a+b;;
            double d=2;
            double pow;
            double fact;
            for(int i=2;i<8;i++)
            {
             
               pow=Math.Pow(2,d);
             
              fact= Fact(d) ; 
              c=c+(pow/fact);
               d++;

            }
            System.Console.WriteLine(c);
           double Fact(double n)
           {
            if(n==1)
            return 1;
            else
            return n*Fact(n-1);
           }
        }
    }
}

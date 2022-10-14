using System;
namespace Question4 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the limit:");
            int limit=int.Parse(Console.ReadLine());
            int temp;
            for(int i=1;i<limit;i++)
            {
                temp=i;
                if(temp==ArmStrong(i))
                {
                    System.Console.Write(i+" ");
                }
            }
            int ArmStrong(int i)
            {
               
               int count=DigitsCount(i);
                int s=0;
               while(i!=0)
               {
               int a=i%10;
               int m=1;
              
               for(int j=0;j<count;j++)
               {
                m=m*a;
               } 
               s=s+m;
               i/=10;
               }
                return s;
               
             
            }
            int DigitsCount(int i)
            {
                int c=0;
                
              while(i!=0)
              {
                  i/=10;
                 c++;
               
              }
              return c;
            }
        }
    }
}

using System;
namespace Question8 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter 1st matrix row and column:"); 
           int r=int.Parse(Console.ReadLine());
           int c=int.Parse(Console.ReadLine());
           int[,] a=new int[r,c];
           System.Console.WriteLine("Enter 2st matrix row and column:"); 
           int r1=int.Parse(Console.ReadLine());
           int c1=int.Parse(Console.ReadLine());
           int[,] b=new int[r1,c1];
           int[,] d=new int[100,100];
           if(c==r1)
           {
            System.Console.WriteLine("Enter 1st matrix:");
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<c;j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }

            }
            System.Console.WriteLine("Enter 2st matrix:");
            for(int i=0;i<r1;i++)
            {
                for(int j=0;j<c1;j++)
                {
                    b[i,j]=int.Parse(Console.ReadLine());
                }

            }
            System.Console.WriteLine("Multiplication:");
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<r;j++)
                {
                   d[i,j]=0;
                   for(int k=0;k<r1;k++)
                   {
                    d[i,j]=(a[i,k]*b[k,j])+d[i,j];
                   } 
                   System.Console.Write(d[i,j]+"  ");
                }
                 System.Console.WriteLine();
            }
           }
           else
           {
            System.Console.WriteLine("not possible");
           }
        }
    }
}

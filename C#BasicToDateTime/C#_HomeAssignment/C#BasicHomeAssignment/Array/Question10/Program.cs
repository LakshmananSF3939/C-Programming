using System;
namespace Question8 
{
    class Program 
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter row and column:"); 
           int row=int.Parse(Console.ReadLine());
           int column=int.Parse(Console.ReadLine());
           int[,] a=new int[row,column];
           System.Console.WriteLine("Enter Matrix elements");
           for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }

            }System.Console.WriteLine("Before Transpose:");
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    System.Console.Write(a[i,j]+" ");
                }
              System.Console.WriteLine();
            }
            System.Console.WriteLine("After Transpose:");
            for(int i=0;i<column;i++)
            {
                for(int j=0;j<row;j++)
                {
                    System.Console.Write(a[j,i]+" ");
                }
               System.Console.WriteLine();
            }
        }
    }
}

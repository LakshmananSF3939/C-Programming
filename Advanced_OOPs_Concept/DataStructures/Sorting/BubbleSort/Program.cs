using System;
namespace BubbleSort ;
class Program
{
    public static void Main(string[] args)
    {
        int[] numbers={18,19,1,5,7,3,20};
        int i,j;
        for(i=0;i<numbers.Length;i++)
        {
            for(j=0;j<numbers.Length-1-i;j++)
            {
                if(numbers[j]>numbers[j+1])
                {
                    int t=numbers[j];
                    numbers[j]=numbers[j+1];
                    numbers[j+1]=t;
                }
            }

        }
        for(i=0;i<numbers.Length;i++)
        {
            if(i==0)
            {
                System.Console.Write(numbers[i]);
                continue;
            }
             else
            {
              System.Console.Write(","+numbers[i]);
            }
           
        }
    }
}

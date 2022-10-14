using System;
namespace InsertionSort;
class Program 
{
    public static void Main(string[] args)
    {
        int[] numbers={18,19,1,5,7,3,20};
        int i,j,key,temp;
        for(i=1;i<numbers.Length;i++)
        {
            key=numbers[i];
            j=i-1;
            while(j>=0&&key<numbers[j])
            {
                temp=numbers[j];
                numbers[j]=numbers[j+1];
                numbers[j+1]=temp;
                j--;
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
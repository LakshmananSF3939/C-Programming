using System;
namespace SelectionSort;
class Program 
{
    public static void Main(string[] args)
    {
        int[] numbers={18,19,1,5,7,3,20};
        int i,j,minimumValue,minimumIndex;
        for(i=0;i<numbers.Length;i++)
        {
            minimumValue=numbers[i];
            minimumIndex=i;
            for(j=i;j<numbers.Length;j++)
            {
                if(numbers[j]<minimumValue)
                {
                    minimumValue=numbers[j];
                    minimumIndex=j;
                }
            }
            if(minimumValue<numbers[i])
            {
                int temp=numbers[i];
                numbers[i]=numbers[minimumIndex];
                numbers[minimumIndex]=temp;
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

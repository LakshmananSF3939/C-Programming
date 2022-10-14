using System;
namespace MergeSort;
class Program 
{
    public static void Main(string[] args)
    {
        int[] numbers={18,19,1,5};
        
        System.Console.WriteLine("Before Sort");
        PresentArray(numbers);
        System.Console.WriteLine("\nMerge Sort");
        MergeSort(numbers,0,numbers.Length-1);
        System.Console.WriteLine("After Sort");
        PresentArray(numbers);
    }
    static void PresentArray(int[] numbers)
    {
        int i;
        for( i=0;i<numbers.Length;i++)
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
    static void MergeSort(int[] numbers,int start,int last)
    {
        if(start<last)
        {
            int middle=(start+last)/2;
            //1st half
            MergeSort(numbers,start,middle);
            //2nd half
            MergeSort(numbers,middle+1,last);
            //merge sorted halfs
            Merge(numbers,start,middle,last);
        }
    }
    static void Merge(int[] numbers,int start,int middle,int last)
    {
           int n1=middle-start+1;
           int n2=last-middle;
           int[] array1=new int[n1];
           int[] array2=new int[n2];
           int i,j;
           for(i=0;i<n1;i++)
           array1[i]=numbers[start+i];
           for(j=0;j<n2;j++)
           array2[j]=numbers[middle+1+j];
           i=0;j=0;
           int k=start;
           while(i<n1 && j<n2)
           {
              if(array1[i]<=array2[j])
              {
                numbers[k]=array1[i];
                i++;
              }
              else
              {
                numbers[k]=array2[j];
                j++;
              }
              k++;
           }
           while(i<n1)
           {
              numbers[k]=array1[i];
              i++;
              k++;
           }
           while(j<n2)
           {
              numbers[k]=array2[j];
              j++;
              k++;
           }
    }
}

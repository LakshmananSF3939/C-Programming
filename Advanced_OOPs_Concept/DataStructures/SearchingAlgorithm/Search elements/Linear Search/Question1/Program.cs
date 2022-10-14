using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        IntegerSearch();
        CharacterSearch();
        StringSearch();
        void IntegerSearch()
        {
            int[] numbers={3,4,7,9,2,5,10};
            int find=5;
            int flag=0;
            for(int search=0;search<numbers.Length;search++)
            {
                if(numbers[search]==find)
                {
                    System.Console.WriteLine($"The  Integer number {numbers[search]} in array position {search}");
                    flag=1;
                }
                
            }
            if(flag==0)
          {
            System.Console.WriteLine("The id is not found");
          }  
        }
        void CharacterSearch()
        {
            char[] charecters={'s','g','d','t','w','e'};
            char find='t';
            int flag=0;
             for(int search=0;search<charecters.Length;search++)
            {
                if(charecters[search]==find)
                {
                    System.Console.WriteLine($"The  Integer number {charecters[search]} in array position {search}");
                    flag=1;
                }
                
            }
            if(flag==0)
          {
            System.Console.WriteLine("The id is not found");
          }  
        }
        void StringSearch()
        {
            string[] fruits={"mango","orange","apple","banana","watermelon"};
            string find="apple";
            int flag=0;
             for(int search=0;search<fruits.Length;search++)
            {
                if(fruits[search]==find)
                {
                    System.Console.WriteLine($"The  Integer number {fruits[search]} in array position {search}");
                    flag=1;
                }
                
            }
            if(flag==0)
          {
            System.Console.WriteLine("The id is not found");
          }  
        }
    }
    
}

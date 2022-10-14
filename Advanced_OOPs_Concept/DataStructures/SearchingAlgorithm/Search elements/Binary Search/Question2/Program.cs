using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        IntegerSearch();
        CharecterSearch();
        StringSearch();
        RandomSearch();
        void IntegerSearch()
        {    
            int[] numbers={11,12,13,14,15,16,17};
            int find=15;
            int beginning=0;
            int end=numbers.Length-1;
            int middle;
            int flag=0;
           
            while(beginning<=end)
            { 
                 middle=(beginning+end)/2;
                
                if(find==numbers[middle])
                {
                  System.Console.WriteLine($"The number {find} and its position {middle}");
                  flag=0;
                }
                
                if(find<numbers[middle])
                    {
                        end=middle-1;
                    }
                    else 
                    {
                        beginning=middle+1;
                    }
                
            }
            if(flag==0)
            {
                System.Console.WriteLine("Not found");
            }
            
        }
        void CharecterSearch()
        {
            char[] elements={'a','b','c','d','e','f'};
            char find='b';
            int beginning=0;
            int end=elements.Length-1;
            int middle;
            int flag=0;
           
            while(beginning<=end)
            { 
                 middle=(beginning+end)/2;
                
                if(find==elements[middle])
                {
                  System.Console.WriteLine($"The letter {find} and its position {middle}");
                  flag=1;
                }
                
                if(find<elements[middle])
                    {
                        end=middle-1;
                    }
                    else 
                    {
                        beginning=middle+1;
                    }
                
            }
            if(flag==0)
          {
            System.Console.WriteLine("The id is not found");
          }  
        }
        void StringSearch()
        {
            string[] fruits={"SF3001","SF3002","SF3003","SF3004","SF3005","SF3006","SF3007","SF3008"};
            string find="SF3007";
            int beginning=0;
            int end=fruits.Length-1;
            int middle;
            int flag=0;
           
            while(beginning<=end)
            { 
                 middle=(beginning+end)/2;
                 int returnValue=find.CompareTo(fruits[middle]);
                 //System.Console.WriteLine(returnValue);
                
                if(returnValue==0)
                {
                  System.Console.WriteLine($"The ID {find} and its position {middle}");
                  flag=1;
                }
                else{
                  if(returnValue<0)
                    {
                        end=middle-1;
                    }
                    else 
                    {
                        beginning=middle+1;
                    }
                }
            }
            if(flag==0)
          {
            System.Console.WriteLine("The id is not found");
          }  
        }
        void RandomSearch()
        {
          string[] employeeIDs={"SF3002","SF3001","SF3007","SF3009","SF3004","SF3010","SF3011","SF3015"};
          string find="SF3011";
          int start=0;
          int end=employeeIDs.Length-1;
          int flag=0;
          while(start<=end)
          {
            int middle=(start+end)/2;
            int returnValue=find.CompareTo(employeeIDs[middle]);
           
            if(returnValue==0)
            {
                System.Console.WriteLine($"The id is found {find}");
                flag=1;
                break;
            }
            else
            {
                if(returnValue<0)
                {
                    end=middle-1;
                }
                else
                {
                    start=middle+1;
                }
            }
          }
          if(flag==0)
          {
            System.Console.WriteLine("The id is not found");
          }  
        }
    }
    
}

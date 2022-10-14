using System;
namespace Whileloop 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int i=0;
            while(i<=25)
            {
                if(i!=0 && i%2==0)
                {
                    System.Console.Write(i+" ");
                }
                i+=2;
            }
            
            
            
             System.Console.WriteLine("\nEnter number");
             int number;
             
                  bool temp=int.TryParse(Console.ReadLine(),out number);
                   while(!temp)
                   {
                  
                     System.Console.WriteLine("In Valid number Enter a valid number");
                     temp=int.TryParse(Console.ReadLine(),out number);
                     
                   }
                   
                     System.Console.WriteLine("valid number");
                   
            
                 }
                   
             }
            }
        
    




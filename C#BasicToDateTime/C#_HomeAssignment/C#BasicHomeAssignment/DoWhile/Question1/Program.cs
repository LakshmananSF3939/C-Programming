using System;
namespace Question1 
{
    class Program 
    {
       public static void Main(string[] args)
       {
        
        int no;
        string codition;
        do 
        {
            System.Console.WriteLine("Enter number:");
            no=Convert.ToInt32(Console.ReadLine());
            if(no%2==0)
            {
                System.Console.WriteLine("The number is Even");
            }
            else
            {
              System.Console.WriteLine("The nuber is Odd");
            }
            System.Console.WriteLine("Do you want change another number");
            codition=Console.ReadLine().ToLower();

        }while(codition=="yes");
       }
    }
}

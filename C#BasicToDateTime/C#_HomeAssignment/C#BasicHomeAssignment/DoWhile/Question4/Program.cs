using System;
namespace Question3 
{
    class Program 
    {
        public static void Main(string[] args)
        {
          int num;
          bool temp;
         
          do
          {
            Console.WriteLine("Enter number:");
            temp=int.TryParse(Console.ReadLine(),out num);
            if(num>=1 && num<=10)
            {
                 System.Console.WriteLine("Output:"+num);
                 
            }
            else
            {
                temp=false;
            }
          } while(!temp);
         
        }
    }
}

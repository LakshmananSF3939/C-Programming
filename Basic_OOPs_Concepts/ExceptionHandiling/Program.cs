using System;
namespace ExceptionHandling 
{
    class program 
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter numbers:");
            

            try
            {
            int number1=int.Parse(Console.ReadLine());
            int number2=int.Parse(Console.ReadLine());
            int output=number1/number2;
            System.Console.WriteLine(output);
            }
            catch(DivideByZeroException e)
            {
                System.Console.WriteLine("An Exception Occured:"+e.Message);
                System.Console.WriteLine(e.StackTrace);
            }
            catch(Exception e)
            {
                System.Console.WriteLine("An Exception occured"+e.Message);
                System.Console.WriteLine(e.StackTrace);
            }
            finally  
            {
              System.Console.WriteLine("All exception handled properly");
            }
     }
            

    }
}

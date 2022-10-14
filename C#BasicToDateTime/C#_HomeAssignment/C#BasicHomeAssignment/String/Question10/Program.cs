using System;
namespace Question10 
{
   class Program 
   {
    public static void Main(string[] args)
     {
         string name="user";
        string password="pass";
        System.Console.WriteLine("enter name:");
        string name1=Console.ReadLine();
        System.Console.WriteLine("Enter password");
        string password1=Console.ReadLine();
        bool temp1=name.Contains(name1);
        bool temp2=password.Contains(password1);
         if(temp1 &&temp2)
         {
            System.Console.WriteLine("Password enterd successfully!!");
         }
         else
         {
            System.Console.WriteLine("Incorrect");
         }
      }
    
    }
}



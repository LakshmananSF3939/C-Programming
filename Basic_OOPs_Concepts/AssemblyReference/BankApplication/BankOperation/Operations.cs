using System;
using System.Collections.Generic;
using BankLibrary;
namespace BankOperation;
public class Operations 
{
    public static void MainMenu()
    {
        List<CustomerDetails> customerList=new List<CustomerDetails>();
        System.Console.WriteLine("Are you willing to open Bank Account:");
         string willing=Console.ReadLine().ToLower();
         double balance=0;
         do
         {
        System.Console.WriteLine("Enter your Name:");
        string name=Console.ReadLine();
        System.Console.WriteLine("Enter your Father Name:");
        string fatherName=Console.ReadLine();
        System.Console.WriteLine("Enter DOB dd/MM/yyyy");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

        System.Console.WriteLine("Enter Gender Default/Male/Female/TransGender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        
        System.Console.WriteLine("Account Type: Default/FD/SB/RD");
        AccountType accountType=Enum.Parse<AccountType>(Console.ReadLine(),true);
        

        CustomerDetails customer1=new CustomerDetails(name,fatherName,dob,gender,accountType,balance);
         
        customerList.Add(customer1);
       
        System.Console.WriteLine(" Account Created!!");
        System.Console.WriteLine("Account No:"+customer1.AccountNumber);
        System.Console.WriteLine("Are you willing to open Bank Account:");
         willing=Console.ReadLine().ToLower();

         }while(willing=="yes");

         foreach(CustomerDetails customer in customerList)
         {
            System.Console.WriteLine("Customer details:");

            System.Console.WriteLine($"Your name is {customer.Name}");
            System.Console.WriteLine($"Your Father name is {customer.FatherName}");
            System.Console.WriteLine($"DOB :{customer.DOB.ToShortDateString()}");
            System.Console.WriteLine($"Gender:{customer.Gender}");
            System.Console.WriteLine($"AccountType:{customer.AccountType}");

            customer.Deposit();
            customer.WithDraw();
            customer.BalanceShow();
            System.Console.WriteLine();
         }
    }
}

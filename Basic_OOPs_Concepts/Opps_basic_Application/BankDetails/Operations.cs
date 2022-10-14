using System;
using System.Collections.Generic;
namespace BankDetails;

    public static class Operations
    {
        static CustomerDetails CurrentCustomer=null;
        static List<CustomerDetails> customerList=new List<CustomerDetails>(); 
        public static void MainMenu()
        {
            string choice="yes";
        do
        {
            
        
        System.Console.WriteLine("Select Option 1.Registration 2.Login 3.Exit");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1: 
            {
                System.Console.WriteLine("Registration");
                Registration();
                break;
            }
            case 2: 
            {
                System.Console.WriteLine("Login");
                Login();
                break;
            }
            case 3: 
            {
                System.Console.WriteLine("Exit");
                choice="no";
                break;
            }

        }
        }while(choice=="yes");
       
        }
        public static void Registration()
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
        CustomerDetails customer1=new CustomerDetails(name,fatherName,dob,gender,accountType); 
        customerList.Add(customer1);
        System.Console.WriteLine("Account No:"+customer1.AccountNumber);
        }
        public static void Login()
        {
          System.Console.WriteLine("Enter your Account Number:");
          string accountNumber=Console.ReadLine();
          foreach(CustomerDetails customer in customerList )
          {
            if(customer.AccountNumber==accountNumber)
            {
                System.Console.WriteLine("Success fully login");
                 CurrentCustomer=customer;
                 SubMenu();
            }
          }
        }

        public static void SubMenu()
        {
           string choice="yes";
           do
           {
            System.Console.WriteLine("Select submenu Number:");
             System.Console.WriteLine("Select Option 1.Show details 2.Deposit 3.WithDraw 4.Show Balance 5.Exit");
             int option=int.Parse(Console.ReadLine());
             switch(option)
             {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    CurrentCustomer.ShowDetails();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Deposit");
                    CurrentCustomer.Deposit();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("With Draw:");
                    CurrentCustomer.WithDraw();
                    break;
                }
                case 4:
                {
                    System.Console.WriteLine("Show Balance");
                    CurrentCustomer.BalanceShow();
                    break;
                }
                case 5:
                {
                    System.Console.WriteLine("Exit subMenu");
                    choice="no";
                    break;
                }
             }

           }while(choice=="yes");
        }
    }


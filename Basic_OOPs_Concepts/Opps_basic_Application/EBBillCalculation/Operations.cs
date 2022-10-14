using System;
using System.Collections.Generic;
namespace EBBillCalculation
{
    public static class Operations
    {
        static EBReadingDetails CurrentCustomer=null;
        static List<EBReadingDetails> calculationList=new List<EBReadingDetails>();
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
            System.Console.WriteLine("Enter your Phone Number");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your Mail Id:");
            string mail=Console.ReadLine();
        
            EBReadingDetails reading1=new EBReadingDetails(name,mobile,mail);
            calculationList.Add(reading1);
            System.Console.WriteLine("EB ID:"+reading1.MeterID);
         }
         public static void Login()
         {
            System.Console.WriteLine("Enter your Meter Number:");
          string meterID=Console.ReadLine();
          foreach(EBReadingDetails customer in calculationList )
          {
            if(customer.MeterID==meterID)
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
             System.Console.WriteLine("Select Option 1.Show details 2.Used Units 3.Calculate 4.Exit");
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
                    System.Console.WriteLine("No.Of used Units:");
                    CurrentCustomer.UsedUnits();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Calculate Tarriff:");
                    CurrentCustomer.CalculateAmount();
                    break;
                }
                
                case 4:
                {
                    System.Console.WriteLine("Exit subMenu");
                    choice="no";
                    break;
                }
             }

           }while(choice=="yes");
         }
    }
}

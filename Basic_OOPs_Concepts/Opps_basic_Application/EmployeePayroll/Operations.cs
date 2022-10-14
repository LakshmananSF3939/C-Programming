using System;
using System.Collections.Generic;
namespace EmployeePayroll
{
    public static class Operations
    {
       static EmployeeDetails CurrentEmployee=null;
       static List<EmployeeDetails> employeeList=new List<EmployeeDetails>(); 
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
            System.Console.WriteLine("Enter your Gender Default/Male/Female/TransGender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Your Role:");
            string role=Console.ReadLine();
            System.Console.WriteLine("Work Location:");
            WorkLocation workLocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter Team Name:");
            string teamName=Console.ReadLine();
            System.Console.WriteLine("Enter date of joining:");
             DateTime dateOfJoining=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
             EmployeeDetails employee1=new EmployeeDetails(name,gender,role,workLocation,teamName,dateOfJoining);
             employeeList.Add(employee1);
             System.Console.WriteLine("Your Employee Id:"+employee1.EmployeeId);

       }
       public static void Login()
       {
          System.Console.WriteLine("Enter your Employee Number:");
          string employeeId=Console.ReadLine();
          foreach(EmployeeDetails customer in employeeList )
          {
            if(customer.EmployeeId==employeeId)
            {
                System.Console.WriteLine("Success fully login");
                 CurrentEmployee=customer;
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
             System.Console.WriteLine("Select Option 1.Show details 2.No Of Leaves 3.Calculate salary 4.Exit");
             int option=int.Parse(Console.ReadLine());
             switch(option)
             {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    CurrentEmployee.ShowDetails();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Deposit");
                    CurrentEmployee.Leaves();
                    break;
                }
                
                case 3:
                {
                    System.Console.WriteLine("Calculate salary");
                    CurrentEmployee.CalculateAmount();
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
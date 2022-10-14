using System;
using System.Collections.Generic;
namespace CollegeAdmission1;

   
    public static class Operations
    { 
        static StudentDetails currentStudent=null;
        static List<StudentDetails> studentList=new List<StudentDetails>();

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
        System.Console.WriteLine("Enter Gender:");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter Mail:");
        string mail=Console.ReadLine();
        System.Console.WriteLine("Enter mobile No:");
        long phone=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Physics Mark:");
        int physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Chemistry Mark:");
        int chemistry=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Maths Mark:");
        int maths=int.Parse(Console.ReadLine()); 
        StudentDetails student1=new StudentDetails(name,fatherName,dob,gender,mail,phone,physics,chemistry,maths);
        studentList.Add(student1);
         System.Console.WriteLine("Register number is "+student1.RegisterNumber);

       }
       public static void Login()
       {
        System.Console.WriteLine("Enter your Rigester Number:");
        string registerNumber=Console.ReadLine().ToUpper();
        foreach(StudentDetails student in studentList)
        {
            if(student.RegisterNumber==registerNumber)
            {
                System.Console.WriteLine("Login Successful");
                currentStudent=student;
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
            System.Console.WriteLine("1.Show Details 2.Check eligibility 3.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    currentStudent.ShowDetails();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Check Eligibility");
                     bool eligible=currentStudent.checkEligibility(75.0);
                     if(eligible)
                      {
                      System.Console.WriteLine("You are eligible for admission");
                      }
                       else
                      {
                      System.Console.WriteLine("You are not eligible for admission");
                       }

                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit Submenu");
                    choice="no";
                    break;
                }
            }

        }while(choice=="yes");
       }
    }


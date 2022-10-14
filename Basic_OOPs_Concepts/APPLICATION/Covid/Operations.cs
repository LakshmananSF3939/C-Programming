using System;
using System.Collections.Generic;
namespace Covid;

    public static class Operations
    {
         static List<BenificiaryDetails> benificiaryList=new List<BenificiaryDetails>();
         static List<Vacine>vaccineList=new List<Vacine>();
         static List<Vaccination> vaccinationList=new List<Vaccination>();
         static BenificiaryDetails CurrentUser=null;
         public static void DefaultData()
         {
            BenificiaryDetails user1=new BenificiaryDetails("Ravichandran",Gender.Male,8484484,"Chennai",21);
            benificiaryList.Add(user1);
            BenificiaryDetails user2=new BenificiaryDetails("Baskaran",Gender.Male,8484747,"Chennai",22);
            benificiaryList.Add(user2);
            Vacine vaccine1=new Vacine(VaccineName.Covidshield,50);
            vaccineList.Add(vaccine1);
            Vacine vaccine2=new Vacine(VaccineName.Covaccine,50);
            vaccineList.Add(vaccine2);
            Vaccination vaccination1=new Vaccination(user1.RegistrationNumber,vaccine1.VaccineID,1,new DateTime(2021,11,11));
            vaccinationList.Add(vaccination1);
            Vaccination vaccination2=new Vaccination(user1.RegistrationNumber,vaccine1.VaccineID,2,new DateTime(2022,03,11));
            vaccinationList.Add(vaccination2);
            Vaccination vaccination3=new Vaccination(user2.RegistrationNumber,vaccine2.VaccineID,1,new DateTime(2022,04,04));
         }
         public static void MainMenu()
         {
            string choice="yes";
            do
           {
            System.Console.WriteLine("Select 1.Benificiary Registration 2.Login 3.Getvaccine Info 4.Exit");
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
                System.Console.WriteLine("LOgin:");
                Login();
                break;
              }
              case 3:
              {
                break;
              }
              case 4:
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
            System.Console.WriteLine("Enter your Age:");
            int age=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Mobile Number:");
            long mobile=long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your City:");
            string city=Console.ReadLine();
            BenificiaryDetails user3=new BenificiaryDetails(name,gender,mobile,city,age);
            benificiaryList.Add(user3);
            System.Console.WriteLine("Your Registration Number:"+user3.RegistrationNumber);
         }
         public static void Login()
         {
            System.Console.WriteLine("Enter your registration Number:");
            string registrationNumber=Console.ReadLine();
            foreach(BenificiaryDetails user in benificiaryList)
            {
                System.Console.WriteLine("Login Successfuly");
                CurrentUser=user;
                SubMenu();
            }
         }
         public static void SubMenu()
         {
            string choice="yes";
            do
            {
                System.Console.WriteLine("select 1.Show My Details 2.Take Vaccination 3.My Vaccination History 4.Next Due Date 5.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Show my details");
                        ShowMyDetails();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Take Vaccination");
                        TakeVaccination();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("My vaccination Histry");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("Next due date");
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
                }

            }while(choice=="yes");
         }
         public static void ShowMyDetails()
         {
            foreach(BenificiaryDetails user in benificiaryList)
            {
                if(CurrentUser.RegistrationNumber==user.RegistrationNumber)
                {
                    System.Console.WriteLine("Your Registration Number:"+user.RegistrationNumber);
                    System.Console.WriteLine("Your Name:"+user.Name);
                    System.Console.WriteLine("Your Age:"+user.Age);
                    System.Console.WriteLine("Gender:"+user.Gender);
                    System.Console.WriteLine("Mobile Number:"+user.MobileNumber);
                    System.Console.WriteLine("City:"+user.City);
                }
            }
         }
         public static void TakeVaccination()
         {
            foreach(Vacine vaccine in vaccineList)
            {
                System.Console.WriteLine(vaccine.VaccineID+"\t"+vaccine.VaccineName+"\t"+vaccine.NumberOfDoses);
            }
            System.Console.WriteLine("select the Vaccine ID");
            string vaccineID=Console.ReadLine();
            foreach(Vacine vaccine1 in vaccineList)
            {
                if(vaccineID==vaccine1.VaccineID)
                {
                    
                }
            }


         }

    }


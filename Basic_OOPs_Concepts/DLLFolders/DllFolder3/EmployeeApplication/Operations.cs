using System;
using EmployeeLibrary;
using System.Collections.Generic;
namespace EmployeeOperation ;
public class Operations 
{
    public static void MainMenu()
    {
        List<EmployeeDetails> employeeList=new List<EmployeeDetails>();
        System.Console.WriteLine("Can you see your salary detail yes/no");
        string willing=Console.ReadLine().ToLower();
        do
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
            System.Console.WriteLine("Enter Month 1-12");
            int month=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter year yyyy format");
            int year=int.Parse(Console.ReadLine());
            int totalDays=DateTime.DaysInMonth(year,month);
            System.Console.WriteLine("Enter leave:");
            int leave=int.Parse(Console.ReadLine());

            EmployeeDetails employee1=new EmployeeDetails(name,gender,role,workLocation,teamName,dateOfJoining,leave,totalDays);
            
            employeeList.Add(employee1);

            System.Console.WriteLine("Can you see your salary detail yes/no");
            willing=Console.ReadLine().ToLower();

        }while(willing=="yes");
        

        foreach(EmployeeDetails employee in employeeList)
        {
            System.Console.WriteLine("Your Employee Id:"+employee.EmployeeId);
            System.Console.WriteLine("Your name is "+employee.EmployeeName);
            System.Console.WriteLine("Gender:"+employee.Gender);
            System.Console.WriteLine("Role:"+employee.Role);
            System.Console.WriteLine("Work Location:"+employee.WorkLocation);
            System.Console.WriteLine("Team Name:"+employee.TeamName);
            System.Console.WriteLine("Date of Joining:"+employee.DateOfJoining.ToShortDateString());
            System.Console.WriteLine($"Your Total working days :{employee.WorkingDays-employee.Leave}");
            employee.CalculateAmount();
            System.Console.WriteLine();
        }
    }
}
